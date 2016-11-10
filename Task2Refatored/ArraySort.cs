using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2Refatored
{
    public class ArraySort
    {
        /// <summary>
        /// Sorts the strings of matrix using interface
        /// </summary>
        /// <param name="array">the array we sort</param>
        /// <param name="sorter">method of sorting</param>
        public static void Sort(int[][] array, IComparer<int[]> sorter)
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(sorter, null))
                throw new NullReferenceException();
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sorter.Compare(array[j], array[j + 1]) < 0)
                    {
                        ChangeRows(ref array[j], ref array[j + 1]);
                    }
                }
            }
            
        }

        /// <summary>
        /// Sorts the strings of matrix using interface
        /// </summary>
        /// <param name="array">the array we sort</param>
        /// <param name="sorter">method of sorting</param>
        public static void Sort(int[][] array, Func<int[], int[], int> sorter) => Sort(array, new DelegateAdapter(sorter));
        
        
        class DelegateAdapter : IComparer<int[]>
        {
            private readonly Func<int[], int[], int> sorter;

            public DelegateAdapter(Func<int[], int[], int> sorter)
            {
                this.sorter = sorter;
            }

            public int Compare(int[] x, int[] y) => sorter(x, y);


        }

        private static void ChangeRows(ref int[] row1, ref int[] row2)
        {
            int[] buffer = row2;
            row2 = row1;
            row1 = buffer;

        }
    }
}
