using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class LinkedListCycleTests
    {
        [TestMethod()]
        public void DetectCycleTest()
        {
            var a = new ListNode(3);
            var b = new ListNode(2);
            var c = new ListNode(2);
            var d = new ListNode(-4);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = b;
            var result = LinkedListCycle.DetectCycle(a);
            Assert.AreEqual(2, result.val);
        }
    }
}