using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class GlassFilter : Filters
    {
        Random r = new Random();

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            int newX = (int) (x + (r.NextDouble() - 0.5) * 10);
            int newY = (int) (y + (r.NextDouble() - 0.5) * 10);

            return ((newX >= sourceImage.Width || newX < 0 || newY >= sourceImage.Height || newY < 0) ? new Color() : sourceImage.GetPixel(newX, newY));
        }

    }
}

