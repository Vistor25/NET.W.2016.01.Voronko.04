using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class CompareRowsByMinInc : IComparer<int[]>
    {
        public int Compare(int[] row1, int[] row2)
        {
            if (row1.Min() < row2.Min()) return 1;
            if (row1.Min() == row2.Min()) return 0;
            return -1;
        }
    }
}
