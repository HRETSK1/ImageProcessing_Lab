using AForge;
using AForge.Imaging;
using AForge.Imaging.ComplexFilters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static Bitmap image;
        public static uint[,] pixelForBrigness;
        public static Bitmap prev;
        public uint pixel;
        private static int count = 0;
        private static Bitmap rollBack;
        private static int threshold = 500;
        private readonly List<NumericUpDown> numud_list = new List<NumericUpDown>();
        private readonly Stopwatch stopWatch = new Stopwatch();
        private readonly ArrayList undoList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        public static System.Drawing.Image Convert(Bitmap oldbmp)
        {
            using (var ms = new MemoryStream())
            {
                oldbmp.Save(ms, ImageFormat.Gif);
                ms.Position = 0;
                return System.Drawing.Image.FromStream(ms);
            }
        }

        public void FromBitmapToScreen()
        {
            pictureBox1.Image = image;
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            timer.Text = string.Format("{0:00h}:{1:00m}:{2:00s}:{3:000ms}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            count++;
            stopWatch.Reset();
        }

        public void ScrollImg(System.Drawing.Image img)
        {
            pictureBox1.Image = img;
        }

        public Bitmap Transformations(Bitmap image, string selection)
        {
            const int RED_PIXEL = 2;
            const int GREEN_PIXEL = 1;
            const int BLUE_PIXEL = 0;
            int MaxVal = 768;
            BitmapData bmData;

            if (threshold < 0)
            {
                return image;
            }
            else if (threshold > MaxVal)
            {
                return image;
            }

            bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);

            try
            {
                int stride = bmData.Stride;
                int bytesPerPixel = (image.PixelFormat == PixelFormat.Format24bppRgb ? 3 : 4);
                Color black = Color.Black;
                Color white = Color.White;

                unsafe
                {
                    byte* pixel = (byte*)(void*)bmData.Scan0;
                    int yMax = image.Height;
                    int xMax = image.Width;

                    for (int y = 0; y < yMax; y++)
                    {
                        int yPos = y * stride;

                        for (int x = 0; x < xMax; x++)
                        {
                            int pos = yPos + (x * bytesPerPixel);

                            switch (selection)
                            {
                                case "Полутон":
                                    pixel[pos + RED_PIXEL] = pixel[pos + GREEN_PIXEL] = pixel[pos + BLUE_PIXEL] = (byte)(((pixel[pos + RED_PIXEL] * 0.3) + (pixel[pos + GREEN_PIXEL] * 0.59) + (pixel[pos + BLUE_PIXEL] * 0.11)));
                                    break;

                                case "Негатив":
                                    pixel[pos + RED_PIXEL] = (byte)(255 - pixel[pos + RED_PIXEL]);
                                    pixel[pos + GREEN_PIXEL] = (byte)(255 - pixel[pos + GREEN_PIXEL]);
                                    pixel[pos + BLUE_PIXEL] = (byte)(255 - pixel[pos + BLUE_PIXEL]);
                                    break;

                                case "Бинаризация":
                                    if ((pixel[pos + RED_PIXEL]) + (pixel[pos + GREEN_PIXEL]) + (pixel[pos + BLUE_PIXEL]) <= threshold)
                                    {
                                        pixel[pos + RED_PIXEL] = black.R;
                                        pixel[pos + GREEN_PIXEL] = black.G;
                                        pixel[pos + BLUE_PIXEL] = black.B;
                                    }
                                    else
                                    {
                                        pixel[pos + RED_PIXEL] = white.R;
                                        pixel[pos + GREEN_PIXEL] = white.G;
                                        pixel[pos + BLUE_PIXEL] = white.B; ;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            finally
            {
                image.UnlockBits(bmData);
            }
            return image;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            threshold = int.Parse(thresholdInput.Text);
            Transformations(image, binarizationToolStripMenuItem.Text);
            FromBitmapToScreen();
            UndoImg();
        }

        private void Brightness_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Form2 BrightnessForm = new Form2(this);
                BrightnessForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Decline_Click(object sender, EventArgs e)
        {
            thresholdInput.Visible = false;
            thresholdInput.Clear();
            acceptBtn.Visible = false;
            declineBtn.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                if (undoList.Count > 0 && count > 0)
                {
                    pictureBox1.Image = (System.Drawing.Image)undoList[count - 1];
                    image = new Bitmap(pictureBox1.Image);
                    count--;
                }
            }
        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                undoList.Clear();
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                rollBack = new Bitmap(image);
                undoList.Add(rollBack);
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (undoList.Count > 0 && count < undoList.Count - 1)
            {
                pictureBox1.Image = (System.Drawing.Image)undoList[count + 1];
                image = new Bitmap(pictureBox1.Image);
                count++;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SourceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = null;
            pictureBox1.Image = new Bitmap(rollBack);
            image = new Bitmap(rollBack);
        }


        private void TheresholdIntput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || ((e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]))) && e.KeyChar != 8;
        }

        private void to_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || ((e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]))) && e.KeyChar != 8;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (undoList.Count > 0 && count > 0)
            {
                pictureBox1.Image = (System.Drawing.Image)undoList[count - 1];
                image = new Bitmap(pictureBox1.Image);
                count--;
            }
        }

        public void UndoImg()
        {
            prev = new Bitmap(image);
            undoList.Add(prev);
        }

        private void semitoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            if (pictureBox1.Image != null)
            {
                Transformations(image, semitoneToolStripMenuItem.Text);
                FromBitmapToScreen();
                UndoImg();
            }
            else
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            if (pictureBox1.Image != null)
            {
                Transformations(image, negativToolStripMenuItem.Text);
                FromBitmapToScreen();
                UndoImg();
            }
            else
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void binarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                thresholdInput.Visible = true;
                acceptBtn.Visible = true;
                declineBtn.Visible = true;
            }
            else
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void matrixFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MatrixFilterForm matrixForm = new MatrixFilterForm(this);
                matrixForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void freqFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrequencyFilterForm form = new FrequencyFilterForm();

            form.InputRange = new IntRange(0, image.Width >> 1);
            form.OutputRange = new IntRange(0, image.Width >> 1);

            if (form.ShowDialog() == DialogResult.OK)
            {
                ComplexImage complexImage = ComplexImage.FromBitmap((Bitmap)Convert(image));
                complexImage.ForwardFourierTransform();
                FrequencyFilter filter = new FrequencyFilter(form.OutputRange);
                filter.Apply(complexImage);
                complexImage.BackwardFourierTransform();
                Bitmap fourierImage = complexImage.ToBitmap();
                image = fourierImage;
                FromBitmapToScreen();
                UndoImg();
            }

        }
        private void детектированиеОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ObjectDetection objDetec = new ObjectDetection(this);
                objDetec.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изображение отсутствует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}