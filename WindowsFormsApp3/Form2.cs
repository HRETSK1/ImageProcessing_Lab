using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        readonly Form1 OwnerForm;
        public Form2(Form1 ownerForm)
        {
            OwnerForm = ownerForm;
            InitializeComponent();
            button1.Click += new System.EventHandler(button_Click);
            button2.Click += new System.EventHandler(button_Click);
        }

        private Bitmap myImage = Form1.image;
        Bitmap prev;
        readonly Stopwatch stopWatch = new Stopwatch();
        private readonly Stack<Image> scrollStack = new Stack<Image>();
        private readonly Stack<int> valueScroll = new Stack<int>();
        private static int temp = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (Form1.image != null)
            {
                stopWatch.Start();
                prev = new Bitmap(Form1.image);
                UndoScroll();
                scrollStack.Push(prev);
                Form1.image = BrightnessContrast.ColorEditor(myImage, trackBar1.Value, "Brightness", 0);
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                FromBitmapToScreen();
                stopWatch.Reset();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (Form1.image != null)
            {
                stopWatch.Start();
                if (textBox1.Text == "") MessageBox.Show("Введите коэффициент", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Form1.image = BrightnessContrast.ColorEditor(myImage, trackBar2.Value, "Contrast", double.Parse(textBox1.Text));
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                    FromBitmapToScreen();
                    stopWatch.Reset();
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (Form1.image != null)
            {
                myImage = Form1.image;
                trackBar1.Value = 0;
                trackBar2.Value = 0;

            }
        }

        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                if (scrollStack.Count > 0)
                {
                    if (trackBar1.Value > 0)
                    {
                        OwnerForm.ScrollImg(scrollStack.Pop());
                        trackBar1.Value = valueScroll.Pop();
                    }
                    else
                    {
                        OwnerForm.ScrollImg(scrollStack.Pop());
                        trackBar1.Value = valueScroll.Pop();
                    }
                }
            }
        }
        private void UndoScroll()
        {
            temp = trackBar1.Value;
            valueScroll.Push(temp);
        }
    }
}
