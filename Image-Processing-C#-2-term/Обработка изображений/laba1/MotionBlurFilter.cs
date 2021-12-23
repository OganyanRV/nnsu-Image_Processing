using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter()
        {
            kernel = new float[9,9];
            for (int i = 0; i < 9; i++)
            {
                kernel[i, i] = ((float)1) / 9;
            }
        }
    }
}
