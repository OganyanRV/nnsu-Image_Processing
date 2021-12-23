using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class DoubleMatrixFilter : Filters
    {
        protected int[,] kernelX = null, kernelY = null;

        protected DoubleMatrixFilter() { }

        public DoubleMatrixFilter(int[,] kernelX, int[,] kernelY)
        {
            this.kernelX = kernelX;
            this.kernelY = kernelY;
        }

        protected override Color calculateNewPixelColor
            (Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernelX.GetLength(0) / 2;
            int radiusY = kernelY.GetLength(1) / 2;

            float resultR = 0, resultG = 0, resultB = 0;
            for (int l = -radiusY; radiusY >= l; ++l)
            for (int k = -radiusX; radiusX >= k; ++k)
            {
                int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                Color neighborColor = sourceImage.GetPixel(idX, idY);

                resultR += neighborColor.R * kernelX[k + radiusX, l + radiusY] + neighborColor.R * kernelY[k + radiusX, l + radiusY];
                resultG += neighborColor.G * kernelX[k + radiusX, l + radiusY] + neighborColor.G * kernelY[k + radiusX, l + radiusY]; ;
                resultB += neighborColor.B * kernelX[k + radiusX, l + radiusY] + neighborColor.B * kernelY[k + radiusX, l + radiusY]; ;
            }

            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }
    }
}