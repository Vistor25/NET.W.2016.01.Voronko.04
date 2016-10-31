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
        [TestCase(null, 1, ExpectedResult = 1)]
        [TestCase(1, '2', null, 4, 5, ExpectedResult = 1)]
        [TestCase( 2, null, 4, -8, ExpectedResult = 2)]
        public long SearchGCDByClassicalEuclideanAlgorythm(params long[] nel)
        {
            return SearhOfGCD.SearchGCDByClassicalEuclideanAlgorythm(nel);
        }

        [TestCase(1, null, ExpectedResult = 1)]
        [TestCase(1, '2', null, 4, 5, ExpectedResult = 1)]
        [TestCase(-2, '2', null, -4, -8, ExpectedResult = 2)]
        public long SearchGCDByBinaryAlgorythm(params long[] nel)
        {
            return SearhOfGCD.SearchGCDByBinaryAlgorythm(nel);
        }
    }
}
