using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class LinearFilter : Filters
    {
        int minR = 255, maxR = 0, minG = 255, maxG = 0, minB = 255, maxB = 0;

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress(((int) (float) i / resultImage.Width * 100));
                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; ++j)
                {
                    Color color = sourceImage.GetPixel(i, j);
                    minR = Math.Min(minR, color.R);
                    maxR = Math.Max(maxR, color.R);
                    minG = Math.Min(minG, color.G);
                    maxG = Math.Max(maxG, color.G);
                    minB = Math.Min(minB, color.B);
                    maxB = Math.Max(maxB, color.B);

                }
            }

            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress((int) ((float) i / resultImage.Width * 100) );
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; ++j)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));

                }
            }

            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int newr = (sourceColor.R - minR) *255 / (maxR - minR),
                newg = (sourceColor.G - minR) * 255 / (maxG - minG),
                newb = (sourceColor.B - minR) * 255 / (maxB - minB);
            Color resultColor = Color.FromArgb(Clamp(newr, 0, 255), Clamp(newg, 0, 255),
                Clamp(newb, 0, 255));

            return resultColor;
        }
    }
}

           
                   
