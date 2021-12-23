using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class ErosionFilter : MathMorphologyFilter
    {
        public ErosionFilter(bool[,] kernel) : base(kernel)
        {
            first = true;
        }
    }
}
