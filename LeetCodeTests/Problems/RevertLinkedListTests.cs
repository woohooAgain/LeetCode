using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class RevertLinkedListTests
    {
        [TestMethod()]
        public void ReverseListTest()
        {
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var reverter = new RevertLinkedList();
            var reverted = reverter.ReverseList(list1);
            Assert.AreEqual(4, reverted.val);
            Assert.AreEqual(2, reverted.next.val);
            Assert.AreEqual(1, reverted.next.next.val);
        }
    }
}