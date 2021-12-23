using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Collections;

namespace laba1
{
    class MathMorphologyFilter : Filters
    {
        protected bool first = false, second = false;
        protected bool[,] mask = null;
        
        public MathMorphologyFilter(bool[,] kernel)
        {
            mask = kernel;
        }

     

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return new Color();
        }

        override public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format1bppIndexed);
            BitmapData imageData = sourceImage.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            byte[] sourceBytes = new byte[Math.Abs(imageData.Stride) * sourceImage.Height];
            IntPtr adress = imageData.Scan0;
            Marshal.Copy(adress, sourceBytes, 0, sourceBytes.Length);
            sourceImage.UnlockBits(imageData);
            byte[] resultBytes = new byte[sourceBytes.Length];

            int StringCount = mask.GetLength(0);
            int ColumnCount = mask.GetLength(1);

            for (int y = ColumnCount / 2; y < sourceImage.Height - ColumnCount / 2; ++y)
            {
                worker.ReportProgress((int)((float)y / sourceImage.Height * 100 ));
                if (worker.CancellationPending)
                    return null;
                for (int x = StringCount / 2; x < sourceImage.Width - StringCount / 2; ++x)
                {
                    bool min = first;
                    for (int j = -ColumnCount / 2; j <= ColumnCount / 2; ++j)
                        for (int i = -StringCount / 2; i <= StringCount / 2; ++i)
                        {
                            bool color = Convert.ToBoolean(sourceBytes[(y + j) * imageData.Stride + (x + i) / 8] & (byte)(0x80 >> ((x + i) % 8)));
                            if (mask[i + StringCount / 2, j + ColumnCount / 2] &&
                                (first && !color && min || !first && color && !min))
                            {
                                min = color;
                            }
                        }

                    if (min)
                        resultBytes[y * imageData.Stride + x / 8] |= (byte)(0x80 >> (x % 8));
                    else
                        resultBytes[y * imageData.Stride + x / 8] &= (byte)~(0x80 >> (x % 8));
                }
            }

            if (second)
            {
                first = !first;
                Array.Copy(resultBytes, sourceBytes, resultBytes.Length);

                for (int y = ColumnCount / 2; y < resultImage.Height - ColumnCount / 2; ++y)
                {
                    worker.ReportProgress((int)((float)y / resultImage.Height * 100 / 2 + 50));

                    if (worker.CancellationPending)
                        return null;

                    for (int x = StringCount / 2; x < resultImage.Width - StringCount / 2; ++x)
                    {
                        bool min = first;
                        for (int j = -ColumnCount / 2; j <= ColumnCount / 2; ++j)
                            for (int i = -StringCount / 2; i <= StringCount / 2; ++i)
                            {
                                bool color = Convert.ToBoolean(sourceBytes[(y + j) * imageData.Stride + (x + i) / 8] & (byte)(0x80 >> ((x + i) % 8)));

                                if (mask[i + StringCount / 2, j + ColumnCount / 2] &&
                                (first && !color && min || !first && color && !min))
                                {
                                    min = color;
                                }
                            }

                        if (min)
                            resultBytes[y * imageData.Stride + x / 8] |= (byte)(0x80 >> (x % 8));
                        else
                            resultBytes[y * imageData.Stride + x / 8] &= (byte)~(0x80 >> (x % 8));
                    }
                }
            }

            imageData = resultImage.LockBits(new Rectangle(0, 0, resultImage.Width, resultImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            Marshal.Copy(resultBytes, 0, imageData.Scan0, resultBytes.Length);
            resultImage.UnlockBits(imageData);
            return resultImage;
        }

       
    }
}
