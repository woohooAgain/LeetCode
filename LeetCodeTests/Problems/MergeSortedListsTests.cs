using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Models;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class MergeSortedListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            var input = new ListNode[3];
            input[0] = new ListNode(1,
                                    new ListNode(4,
                                                 new ListNode(5)));
            input[1] = new ListNode(1,
                                    new ListNode(3,
                                                 new ListNode(4)));
            input[2] = new ListNode(2,
                                    new ListNode(6));
            var result = MergeSortedLists.MergeKLists(input);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.next.val);
            Assert.AreEqual(5, result.next.next.next.next.next.next.val);
            Assert.AreEqual(6, result.next.next.next.next.next.next.next.val);

            input = new ListNode[0];
            result = MergeSortedLists.MergeKLists(input);
            Assert.AreEqual(null, result);

            input = new ListNode[1];;
            result = MergeSortedLists.MergeKLists(input);
            Assert.AreEqual(null, result);
        }
    }
}