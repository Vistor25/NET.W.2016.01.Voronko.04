using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Tests
{
    [TestFixture]
    public class SearhOfGCDTests
    {
        [TestCase(1, 2, ExpectedResult = 1)]
        [TestCase(1, 2, 3, 4, 5, ExpectedResult = 1)]
        public long SearchGCDByClassicalEuclideanAlgorythm(params long[] nel)
        {
            return SearhOfGCD.SearchGCDByClassicalEuclideanAlgorythm(nel);
        }

    }
}
