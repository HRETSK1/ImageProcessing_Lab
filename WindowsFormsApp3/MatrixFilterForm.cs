using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class MatrixFilterForm : Form
    {
        readonly Form1 OwnerForm;
        private readonly List<NumericUpDown> numud_list = new List<NumericUpDown>();
        public MatrixFilterForm(Form1 ownerForm)
        {
            OwnerForm = ownerForm;
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NumericUpDown numbUD = new NumericUpDown();
                    numbUD.DecimalPlaces = 1;
                    numbUD.Top = i * 20 + 100;
                    numbUD.Width = 45;
                    numbUD.Minimum = -numbUD.Maximum;
                    numbUD.Left = (int)((numbUD.Width + 2) * (j + 0.5));
                    numud_list.Add(numbUD);
                    numbUD.Value = 1;
                    this.panel1.Controls.Add(numbUD);
                }
            }
        }

        public MatrixFilterForm()
        {
            InitializeComponent();
        }
        public void generate_conv(int[] conv_array)
        {
            //matrixType.SelectedItem = "ВЧ";
            int val = (int)Math.Sqrt(conv_array.Length);
            nudConvSize.Value = val;
            for (int i = 0; i < val * val; i++)
            {
                numud_list.ElementAt(i).Value = conv_array[i];
            }
        }

        private void BuildMatrix(string type)
        {
            if (matrixType.SelectedItem == null)
            {
                errorProvider1.SetError(matrixType, "Не выбран тип мартицы");
            }
            else
            {
                
                double sumEl = 0.0;
                errorProvider1.Clear();
                int val = (int)nudConvSize.Value;
                double[,] conv_matrix = new double[val, val];
                int pos = 0;
                switch (type)
                {
                    case "ВЧ":
                        for (int i = 0; i < val; i++)
                        {
                            for (int k = 0; k < val; k++)
                            {
                                conv_matrix[i, k] = (double)numud_list.ElementAt(pos).Value;
                                pos++;
                            }
                        }

                        break;

                    case "НЧ":
                        for (int i = 0; i < val * val; i++)
                        {
                            sumEl += (int)numud_list.ElementAt(i).Value;
                        }
                        for (int i = 0; i < val; i++)
                        {
                            for (int k = 0; k < val; k++)
                            {
                                conv_matrix[i, k] = (double)numud_list.ElementAt(pos).Value / sumEl;
                                pos++;
                            }
                        }
                        break;
                }
                GenericFilter sharpen = new GenericFilter();
                sharpen.FilterName = "Sharpen";
                sharpen.FilterMatrix = conv_matrix;
                Form1.image = Form1.image.ConvolutionFilter(sharpen);
                FromBitmapToScreen();
                UndoImg();
            }
        }
        private void nudConvSize_ValueChanged(object sender, EventArgs e)
        {
            int val = (int)nudConvSize.Value;
            numud_list.ForEach(delegate (NumericUpDown numbUD)
            {
                this.panel1.Controls.Remove(numbUD);
            });
            numud_list.Clear();

            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    NumericUpDown numbUD = new NumericUpDown();
                    numbUD.DecimalPlaces = 1;
                    numbUD.Top = i * 20 + 100;
                    numbUD.Width = 45;
                    numbUD.Minimum = -numbUD.Maximum;
                    numbUD.Left = (int)((numbUD.Width + 2) * (j + 0.5));
                    //if (i == (val / 2) && j == (val / 2) && val % 2 == 1)
                    numbUD.Value = 1;
                    numud_list.Add(numbUD);
                    this.panel1.Controls.Add(numbUD);
                }
            }
        }
        private void FilterAccept_Click(object sender, EventArgs e)
        {
            if (Form1.image != null)
            {
                BuildMatrix((string)matrixType.SelectedItem);
            }
            else
            {
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

        void SourseImage()
        {
            Form1.image = Form1.rollBack;
            FromBitmapToScreen();
        }
        void UndoImg()
        {
            OwnerForm.UndoImg();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generate_conv(new int[9] { 1, 0, -1, 2, 0, -2, 1, 0, -1 });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generate_conv(new int[9] { -2, -1, 0, -1, 1, 1, 0, 1, 2 });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generate_conv(new int[25] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            matrixType.SelectedItem = "НЧ";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generate_conv(new int[25] { 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1, 5, -1, 0, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0 });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generate_conv(new int[9] { 0, 1, 0, 1, -4, 1, 0, 1, 0 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SourseImage();
         }

        private void matrixType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matrixType.SelectedItem == "ВЧ")
            {
                generate_conv(new int[9] { -1, -1, -1, -1, 9, -1, -1, -1, -1 });
                // matrixType.SelectedItem = "ВЧ";
            }
            else
            {
                generate_conv(new int[9] { 1, 1, 1, 1, 1, 1, 1, 1, 1 });
                //matrixType.SelectedItem = "НЧ";
            }
        }

    }
}
