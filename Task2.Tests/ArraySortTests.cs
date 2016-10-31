using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Tests
{
    [TestClass]
    public class ArraySortTests
    {
        [TestMethod]
        public void TestCompareBySum()
        {
            int[][] array = {
            new[] {1, -2, 3},
            new[] {0, 2, 13, 4},
            new[] {1, 3},
            new[] {14}
        };
            int[][] testArray =  {
             new[] {0, 2, 13, 4},
             new[] {14},
             new[] {1, 3},
             new[] {1, -2, 3},
        };
           ArraySort.Sort(array, ArraySort.CompareBySum);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }
        [TestMethod]
        public void TestCompareByMaxElementm()
        {
            int[][] array = {
            new[] {1, -2, 3},
            new[] {0, 2, 13, 4},
            new[] {1, 3},
            new[] {14}
        };
            int[][] testArray =  {
             new[] {14},
             new[] {0, 2, 13, 4},
             new[] {1, -2, 3},
             new[] {1, 3},
             
        };
            ArraySort.Sort(array, ArraySort.CompareByMaxElement);

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
            ArraySort.Sort(array, ArraySort.CompareByMinElement);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }
    }
}
