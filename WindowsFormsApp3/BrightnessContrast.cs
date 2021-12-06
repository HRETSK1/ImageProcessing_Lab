using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    internal class BrightnessContrast
    {
        public static Bitmap ColorEditor(Bitmap sourceBitmap, int Value, string selection, double u)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                 sourceBitmap.Width, sourceBitmap.Height),
                                 ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            double c = selection == "Contrast" ? Value / 10.0 : Value;
            double blue = 0;
            double green = 0;
            double red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                switch (selection)
                {
                    case "Contrast":
                        blue = c * Math.Pow(pixelBuffer[k], u);

                        green = c * Math.Pow(pixelBuffer[k + 1], u);

                        red = c * Math.Pow(pixelBuffer[k + 2], u);
                        break;
                    case "Brightness":
                        blue = c * Math.Log(pixelBuffer[k] + 1);

                        green = c * Math.Log(pixelBuffer[k + 1] + 1);

                        red = c * Math.Log(pixelBuffer[k + 2] + 1);

                        break;
                }

                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }

                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }

                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }
}