using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortWithInterface
{
    class CompareRowsBysum : IArraySorter
    {
        public int CompareRows(int[] row1, int[] row2)
        {
            if (row1.Sum() > row2.Sum()) return 1;
            if (row1.Sum() == row2.Sum()) return 0;
            return -1;
        }
    }
}
