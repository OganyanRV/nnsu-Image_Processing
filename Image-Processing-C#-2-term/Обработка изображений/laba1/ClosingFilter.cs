using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class ClosingFilter : MathMorphologyFilter
    {
        public ClosingFilter(bool[,] kernel) : base(kernel)
        {
            first = false;
            second = true;
        }
    }
}
