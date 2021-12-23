using System;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace laba1
{
    class MedianFilter : Filters {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Bitmap copyImage = sourceImage.Clone(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), PixelFormat.Format24bppRgb);

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format24bppRgb);

            BitmapData imageData = copyImage.LockBits(new Rectangle(0, 0, copyImage.Width, copyImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int stride = imageData.Stride;
            int s = 3;
            int radiusX = s / 2, radiusY = s / 2;

            int[] red = new int[s * s], blue = new int[s * s], green = new int[s * s];
            byte[] sourceBytes = new byte[Math.Abs(imageData.Stride) * sourceImage.Height];


            for (int l = -radiusY; radiusY >= l; ++l)
            for (int k = -radiusX; radiusX >= k; ++k)
            {
                int idX = Clamp(x + k, 0, stride / 3 - 1);
                int idY = Clamp(y + l, 0, sourceBytes.Length / stride - 1);

                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                red[(k + radiusX) + s * (l + radiusY)] = neighborColor.R;
                green[(k + radiusX) + s * (l + radiusY)] = neighborColor.G;
                blue[(k + radiusX) + s * (l + radiusY)] = neighborColor.B;
            }

            Array.Sort(red);  Array.Sort(green);  Array.Sort(blue);

            int ansred ;
            int ansgreen ;
            int ansblue;
            if (s * s % 2 == 1)
            {
                ansred = red[s * s / 2];
                ansgreen = green[s * s / 2];
                ansblue = blue[s * s / 2];
            }
            else
            {
                ansred= (red[s * s / 2] + red[s * s / 2 - 1]) / 2;
                ansgreen = (green[s * s / 2] + green[s * s / 2 - 1]) / 2;
                ansblue = (blue[s * s / 2] + blue[s * s / 2 - 1]) / 2;
            }

            return Color.FromArgb(ansred, ansgreen, ansblue);

        }
    }
}
