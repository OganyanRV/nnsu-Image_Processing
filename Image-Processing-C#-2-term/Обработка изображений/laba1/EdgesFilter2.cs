using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class EdgesFilter2 : EdgesFilter
    {
        public EdgesFilter2()
        {
            kernelX = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, {1, 1, 1 } };
            kernelY = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
        }
    }
}
