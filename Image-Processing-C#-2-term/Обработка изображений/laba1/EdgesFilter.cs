using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class EdgesFilter : DoubleMatrixFilter
    {
        public EdgesFilter()
        {
            kernelX = new int[,] { { 3, 0, -3 }, { 10, 0, -10 }, { 3, 0, -3 } };
            kernelY = new int[,] { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };
        }
    }
}
