using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortWithInterface
{
    public class ArraySort
    {
        /// <summary>
        /// Sorts the strings of two dimensional array
        /// </summary>
        /// <param name="array">Array that we sort</param>
        /// <param name="sorter">Method of sorting</param>
        /// <returns>Sorted array</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static int[][] Sort(int[][] array, IArraySorter sorter)
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(sorter, null))
                throw new NullReferenceException();
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sorter.CompareRows(array[j], array[j + 1]) < 0)
                    {
                        ChangeRows(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }
        private static void ChangeRows(ref int[] row1, ref int[] row2)
        {
            int[] buffer = row2;
            row2 = row1;
            row1 = buffer;

        }
    }
}
