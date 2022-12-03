using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class BinTreeLevelOrderTests
    {
        [TestMethod()]
        public void LevelOrderIterTest()
        {
            var root = new TreeNode(
                3, 
                new TreeNode(9), 
                new TreeNode(
                    20,
                    new TreeNode(15), 
                    new TreeNode(7)));
            var result = BinTreeLevelOrder.LevelOrderIter(root);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(3, result[0][0]);
            Assert.AreEqual(9, result[1][0]);
            Assert.AreEqual(20, result[1][1]);
            Assert.AreEqual(15, result[2][0]);
            Assert.AreEqual(7, result[2][1]);

            root = new TreeNode(
                1,
                null,
                new TreeNode(2));
            result = BinTreeLevelOrder.LevelOrderIter(root);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(2, result[1][0]);

            root = new TreeNode(
                1,
                new TreeNode(2, new TreeNode(4), null),
                new TreeNode(3, null, new TreeNode(5)));
            result = BinTreeLevelOrder.LevelOrderIter(root);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(2, result[1][0]);
            Assert.AreEqual(3, result[1][1]);
            Assert.AreEqual(4, result[2][0]);
            Assert.AreEqual(5, result[2][1]);
        }
    }
}