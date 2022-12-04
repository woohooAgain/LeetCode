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
    public class NextPermutationTests
    {
        [TestMethod()]
        public void NextPermutationActionTest()
        {
            var input = new int[] { 1, 2, 3 };
            NextPermutation.NextPermutationAction(input);
            Assert.AreEqual(1, input[0]);
            Assert.AreEqual(3, input[1]);
            Assert.AreEqual(2, input[2]);

            input = new int[] { 3, 2, 1 };
            NextPermutation.NextPermutationAction(input);
            Assert.AreEqual(1, input[0]);
            Assert.AreEqual(2, input[1]);
            Assert.AreEqual(3, input[2]);

            input = new int[] { 1, 1, 5 };
            NextPermutation.NextPermutationAction(input);
            Assert.AreEqual(1, input[0]);
            Assert.AreEqual(5, input[1]);
            Assert.AreEqual(1, input[2]);

            input = new int[] { 1, 5, 4, 1 };
            NextPermutation.NextPermutationAction(input);
            Assert.AreEqual(4, input[0]);
            Assert.AreEqual(1, input[1]);
            Assert.AreEqual(1, input[2]);
            Assert.AreEqual(5, input[3]);
        }
    }
}