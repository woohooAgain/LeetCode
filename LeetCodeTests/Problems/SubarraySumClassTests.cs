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
    public class SubarraySumClassTests
    {
        [TestMethod()]
        public void SubarraySumTest()
        {
            var c = new SubarraySumClass();
            var result = c.SubarraySum(new int[] { 1, 2, 3 }, 3);
            Assert.AreEqual(2, result);
            result = c.SubarraySum(new int[] { 1, 1, 1 }, 2);
            Assert.AreEqual(2, result);
        }
    }
}