﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ArraySort
    {
        /// <summary>
        /// Sorts jagged array according to chosen method of sorting.
        /// </summary>
        /// <param name="array">Sorting array</param>
        /// <param name="Compare">Method of sorting</param>
        /// <returns>Sorted array</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static int[][] Sort(int[][] array, CompareRows Compare )
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(Compare, null))
                throw new NullReferenceException();
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Compare(array[j], array[j + 1]) < 0)
                    {
                        ChangeRows(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }

       public delegate int CompareRows(int[] row1, int[] row2);

        public static int CompareBySum(int[] row1, int[] row2)
        {
            if (row1.Sum()>row2.Sum()) return 1;
            if (row1.Sum() == row2.Sum()) return 0;
            return -1;
        }

        public static int CompareByMaxElement(int[] row1, int[] row2)
        {
            if (row1.Max() > row2.Max()) return 1;
            if (row1.Max() == row2.Max()) return 0;
            return -1;
        }

        public static int CompareByMinElement(int[] row1, int[] row2)
        {
            if (row1.Min() < row2.Min()) return 1;
            if (row1.Min() == row2.Min()) return 0;
            return -1;
        }

        private static void ChangeRows(ref int[] row1, ref int[] row2)
        {
            int[] buffer = row2;
            row2 = row1;
            row1 = buffer;

        }
    }
}
