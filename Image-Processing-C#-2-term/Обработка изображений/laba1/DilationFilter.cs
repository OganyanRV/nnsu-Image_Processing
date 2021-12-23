using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class DilationFilter : MathMorphologyFilter
    {
        public DilationFilter(bool[,] kernel) : base(kernel)
        {
            first = false;
        }
    }
}
