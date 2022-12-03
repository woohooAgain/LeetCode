using LeetCode;
using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Problems
{
    [TestClass()]
    public class MergeListsTests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var merger = new MergeLists();
            var merged = merger.MergeTwoLists(list1, list2);
            Assert.AreEqual(1, merged.val);
            Assert.AreEqual(1, merged.next.val);
            Assert.AreEqual(2, merged.next.next.val);
            Assert.AreEqual(3, merged.next.next.next.val);
            Assert.AreEqual(4, merged.next.next.next.next.val);
            Assert.AreEqual(4, merged.next.next.next.next.next.val);
            merged = merger.MergeTwoLists(null, null);
            Assert.AreEqual(null, merged);
        }
    }
}