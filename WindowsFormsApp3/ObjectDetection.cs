using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alturos.Yolo;
using Alturos.Yolo.Model;

namespace WindowsFormsApp3
{
    public partial class ObjectDetection : Form
    {
        readonly Form1 OwnerForm;
        public ObjectDetection(Form1 ownerForm)
        {
            OwnerForm = ownerForm;
            InitializeComponent();
        }


        private void accept_detect_Click(object sender, EventArgs e)
        {
            int objNumber = 1;
            label1.Text = "Идёт обработка";
            YoloWrapper yolo = new YoloWrapper("yolov3.cfg", "yolov3.weights", "coco.names");
            MemoryStream ms = new MemoryStream();
            Form1.image.Save(ms, ImageFormat.Jpeg);
            textBox1.Visible = true;
            List<YoloItem> objList = yolo.Detect(ms.ToArray()).ToList<YoloItem>();
            Image img = Form1.image;
            Graphics g = Graphics.FromImage(img);

            Font font = new Font("Consolas", 16, FontStyle.Bold);
            SolidBrush sbrush = new SolidBrush(Color.Blue);
            foreach (YoloItem i in objList)
            {
               // if (i.Type == "bus" || i.Type == "train")
                {
                    var title = $"{objNumber} {i.Type}";
                    Point point = new Point(i.X, i.Y);
                    Size size = new Size(i.Width, i.Height);
                    Rectangle rect = new Rectangle(point, size);
                    Pen pen = new Pen(Color.Blue, 3);
                    g.DrawRectangle(pen, rect);
                    g.DrawString(title, font, sbrush, point);
                    textBox1.AppendText($"{objNumber++.ToString().PadRight(3, ' ')} {i.Type.PadRight(16, ' ')} {i.Confidence}");
                    textBox1.AppendText(Environment.NewLine);
                    label1.Text = "Обработка завершена";
                }
              //  else
                //    label1.Text = "Указанные объекты не найдены";
            }
            Form1.image = new Bitmap(img);
                      
            FromBitmapToScreen();
        }

        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

    }
}
