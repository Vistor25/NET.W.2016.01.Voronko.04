using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortWithInterface
{
   public interface IArraySorter
    {
        int CompareRows(int[] row1, int[] row2);
    }
}
