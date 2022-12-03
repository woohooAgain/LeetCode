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
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            var result = BinarySearch.Search(new[] { -1, 0, 3, 5, 9, 12 }, 9);
            Assert.AreEqual(4, result);
            result = BinarySearch.Search(new[] { -1, 0, 3, 5, 9, 12 }, 2);
            Assert.AreEqual(-1, result);
            result = BinarySearch.Search(new[] { 2, 5 }, 5);
            Assert.AreEqual(1, result);
            result = BinarySearch.Search(new[] { 2, 5 }, 0);
            Assert.AreEqual(-1, result);
        }
    }
}