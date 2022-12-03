using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class MiddleLinkedListTests
    {
        [TestMethod()]
        public void MiddleNodeTest()
        {
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var middler = new MiddleLinkedList();
            var middle = middler.MiddleNode(list1);
            Assert.AreEqual(2, middle.val);
        }
    }
}