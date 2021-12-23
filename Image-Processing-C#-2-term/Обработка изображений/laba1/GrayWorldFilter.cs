using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class GrayWorldFilter : Filters
    {
        double sumR = 0, sumG = 0, sumB = 0;

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress(((int)(float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                {
                    return null;
                }

                for (int j = 0; j < sourceImage.Height; ++j)
                {
                    Color color = sourceImage.GetPixel(i, j);
                    sumR += color.R;
                    sumG += color.G;
                    sumB += color.B;
                }
            }

            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
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
            int newr = (int)(sourceColor.R * (sumR + sumG + sumB) / sumR / 3),
                newg = (int)(sourceColor.G * (sumR + sumG + sumB) / sumG / 3),
                newb = (int)(sourceColor.B * (sumR + sumG + sumB) / sumB / 3);
            Color resultColor = Color.FromArgb(Clamp(newr, 0, 255), Clamp(newg, 0, 255),
                Clamp(newb, 0, 255));
            return resultColor;
        }
    }
}
