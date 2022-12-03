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
    public class RepeatedElementTests
    {
        [TestMethod()]
        public void RepeatedNTimesTest()
        {
            var result = RepeatedElement.RepeatedNTimes(new int[] { 1, 2, 3, 3 });
            Assert.AreEqual(3, result);

            result = RepeatedElement.RepeatedNTimes(new int[] { 2, 1, 2, 5, 3, 2 });
            Assert.AreEqual(2, result);
        }
    }
}