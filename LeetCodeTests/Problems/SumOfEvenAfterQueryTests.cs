using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class SumOfEvenAfterQueryTests
    {
        [TestMethod()]
        public void SumEvenAfterQueriesTest()
        {
            var result = SumOfEvenAfterQuery.SumEvenAfterQueries(
                new int[] { 1, 2, 3, 4 },
                new int[][] { new int[] { 1, 0 }, new int[] { -3, 1 }, new int[] { -4, 0 }, new int[] { 2, 3 } });
            Assert.AreEqual(8, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(4, result[3]);

            result = SumOfEvenAfterQuery.SumEvenAfterQueries(
                new int[] { 1 },
                new int[][] { new int[] { 4, 0 }});
            Assert.AreEqual(0, result[0]);
        }
    }
}