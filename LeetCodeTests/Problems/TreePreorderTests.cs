using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class TreePreorderTests
    {
        [TestMethod()]
        public void PreorderTest()
        {
            var root = new Node(1, new List<Node>
            {
                new Node(3, new List<Node>
                {
                    new Node(5),
                    new Node(6)
                }),
                new Node(2),
                new Node(4),
            });
            var result = TreePreorder.PreorderRecur(root).ToList();
            Assert.AreEqual(6, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(6, result[3]);
            Assert.AreEqual(2, result[4]);
            Assert.AreEqual(4, result[5]);
        }

        [TestMethod()]
        public void PreorderIterTest()
        {
            var root = new Node(1, new List<Node>
            {
                new Node(3, new List<Node>
                {
                    new Node(5),
                    new Node(6)
                }),
                new Node(2),
                new Node(4),
            });
            var result = TreePreorder.PreorderIter(root).ToList();
            Assert.AreEqual(6, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(6, result[3]);
            Assert.AreEqual(2, result[4]);
            Assert.AreEqual(4, result[5]);
        }
    }
}