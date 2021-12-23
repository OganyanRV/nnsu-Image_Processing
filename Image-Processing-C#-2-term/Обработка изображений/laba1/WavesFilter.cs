using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class WavesFilter : Filters
    {
        
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newx = (int ) (x + 20 * Math.Sin(2 * Math.PI * y / 60));
            return (newx >= sourceImage.Width || newx < 0 ? new Color() : sourceImage.GetPixel(newx, y));

        }
    }
}