using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class OpeningFilter : MathMorphologyFilter
    {
        public OpeningFilter(bool[,] kernel) : base(kernel)
        {
            first = true;
           second = true;
        }

    }
}
