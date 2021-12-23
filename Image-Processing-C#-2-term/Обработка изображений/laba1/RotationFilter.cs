using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class RotationFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int midx = sourceImage.Width / 2;
            int midy = sourceImage.Height / 2;
            int newx = (int) ((x - midx) * (int) Math.Cos(0.785398) - (y - midy) * (int) Math.Sin(0.785398) + midx);
            int newy = (int) ((x - midx) * (int) Math.Sin(0.785398) + (y - midy) * (int) Math.Cos(0.785398) + midy);
            return (newx >= sourceImage.Width || newx < 0 || newy >= sourceImage.Height || newy < 0 ? new Color() : sourceImage.GetPixel(newx, newy));
        }
    }
}
