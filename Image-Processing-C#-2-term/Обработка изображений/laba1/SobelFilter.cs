using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class SobelFilter : DoubleMatrixFilter
    {
        public SobelFilter()
        {
            kernelY = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            kernelX = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
        }
    }
}