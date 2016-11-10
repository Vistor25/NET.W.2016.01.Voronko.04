using System;
using System.Collections;
using ArraySortWithInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Refatored;

namespace Task2.Tests
{
    [TestClass]
    public class ArraySortTests
    {
        //[TestMethod]
        //public void TestCompareBySum()
        //{
        //    int[][] array = {
        //    new[] {-16, -4, 3},
        //    new[] {0, 2, 13, 4},
        //    new[] {1, 3,7,11},
        //    new[] {14}
        //};
        //    int[][] testArray =  {
        //     new[] {0, 2, 13, 4},
        //     new[] {14},
        //     new[] {1, 3},
        //     new[] {1, -2, 3},
        //};
        //   ArraySort.Sort(array,);

        //    IStructuralEquatable arrays = array;

        //    Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        //}
        [TestMethod]
        public void TestCompareByMaxElementm()
        {
            int[][] array = {
            new[] {-16, -4, 3},
            new[] {0, 2, 13, 4},
            new[] {1, 3},
            new[] {14}
        };
            int[][] testArray =  {
             new[] {14},
             new[] {0, 2, 13, 4},
             new[] {-16, -4, 3},
             new[] {1, 3},
             
        };
            ArraySort.Sort(array, new CompareRowsByMaxDec());

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }
        [TestMethod]
        public void TestCompareByMinElement()
        {
            int[][] array = {
            new[] {1, -2, 3},
            new[] {0, 2, 13, 4},
            new[] {1, 3},
            new[] {14}
        };
            int[][] testArray =  {
             new[] {1, -2, 3},
             new[] {0, 2, 13, 4},
             new[] {1, 3},
             new[] {14},

        };
            ArraySort.Sort(array, new CompareRowsByMaxInc());

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }
    }
}
