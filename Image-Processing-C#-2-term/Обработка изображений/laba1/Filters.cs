using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    abstract class Filters
    {
       // protected int width, height, stride;
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);

        virtual public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; ++i)
            {
                worker.ReportProgress(((int)(float)i/resultImage.Width*100));
                if (worker.CancellationPending)
                {
                    return null;
                }
                for (int j = 0; j < sourceImage.Height; ++j)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }

            return resultImage;
        }

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }
    };
    
}
