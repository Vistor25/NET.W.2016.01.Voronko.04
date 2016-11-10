using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortWithInterface
{
    class CompareRowsByMaxDec : IComparer<int[]>
    {
        public int Compare(int[] row1, int[] row2)
        {
            if (row1.Max() > row2.Max()) return 1;
            if (row1.Max() == row2.Max()) return 0;
            return -1;
        }
    }
}
