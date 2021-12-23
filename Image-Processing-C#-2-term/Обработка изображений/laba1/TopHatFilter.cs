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
    class TopHatFilter : Filters
    {
        protected bool[,] mask = null;

        public TopHatFilter(bool[,] kernel)
        {
            mask = kernel;
        }

        public Tuple<byte[], BitmapData, Bitmap> Converttobyte(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format1bppIndexed);
            BitmapData imageData = sourceImage.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            byte[] sourceBytes = new byte[Math.Abs(imageData.Stride) * sourceImage.Height];
            return Tuple.Create(sourceBytes, imageData, resultImage);

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
            byte[] middlestep = new byte[sourceBytes.Length];
            int StringCount = mask.GetLength(0);
            int ColumnCount = mask.GetLength(1);
            for (int y = ColumnCount / 2; y < resultImage.Height - ColumnCount / 2; ++y)
            {
                worker.ReportProgress((int)((float)y / resultImage.Height * 100 / 2));
                if (worker.CancellationPending)
                {
                    return null;
                }
                for (int x = StringCount / 2; x < resultImage.Width - StringCount / 2; ++x)
                {
                    bool min = true;
                    for (int j = -ColumnCount / 2; j <= ColumnCount / 2; ++j)
                        for (int i = -StringCount / 2; i <= StringCount / 2; ++i)
                        {
                            bool color = Convert.ToBoolean(sourceBytes[(y + j) * imageData.Stride + (x + i) / 8] & (byte)(0x80 >> ((x + i) % 8)));
                            if (mask[i + StringCount / 2, j + ColumnCount / 2] && !color && min)
                            {
                                min = color;
                            }
                        }
                    if (min)
                    {
                        middlestep[y * imageData.Stride + x / 8] |= (byte)(0x80 >> (x % 8));
                    }
                    else
                    {
                        middlestep[y * imageData.Stride + x / 8] &= (byte)~(0x80 >> (x % 8));
                    }
                       
                }
            }
            for (int y = ColumnCount / 2; y < resultImage.Height - ColumnCount / 2; ++y)
            {
                worker.ReportProgress((int)((float)y / resultImage.Height * 100 / 2 + 50));
                if (worker.CancellationPending)
                {
                    return null;
                }
                for (int x = StringCount / 2; x < resultImage.Width - StringCount / 2; ++x)
                {
                    bool min = false;
                    for (int j = -ColumnCount / 2; j <= ColumnCount / 2; ++j)
                        for (int i = -StringCount / 2; i <= StringCount / 2; ++i)
                        {
                            bool color = Convert.ToBoolean(middlestep[(y + j) * imageData.Stride + (x + i) / 8] & (byte)(0x80 >> ((x + i) % 8)));
                            if (mask[i + StringCount / 2, j + ColumnCount / 2] && color && !min)
                            {
                                min = color;
                            }
                        }
                    if (min) { resultBytes[y * imageData.Stride + x / 8] |= (byte)(0x80 >> (x % 8)); }
                    else { resultBytes[y * imageData.Stride + x / 8] &= (byte)~(0x80 >> (x % 8)); }
                }
            }
            for (int j = 0; j < resultImage.Height; j++)
                for (int i = 0; i < resultImage.Width / 8 + ((resultImage.Width % 8 > 0) ? 1 : 0); i++)
                {
                    byte a = sourceBytes[j * imageData.Stride + i];
                    byte d = resultBytes[j * imageData.Stride + i];
                    sourceBytes[j * imageData.Stride + i] = (byte)(a & ~d);
                }
            imageData = resultImage.LockBits(new Rectangle(0, 0, resultImage.Width, resultImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            Marshal.Copy(sourceBytes, 0, imageData.Scan0, sourceBytes.Length);
            resultImage.UnlockBits(imageData);
            return resultImage;
        }
    }
}
