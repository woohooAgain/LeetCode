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
    public class RemoveNodeFromTheEndTests
    {
        [TestMethod()]
        public void RemoveNthFromEndTest()
        {
            var input = new Models.ListNode(1,
                                            new Models.ListNode(2,
                                                                new Models.ListNode(3,
                                                                                    new Models.ListNode(4,
                                                                                                        new Models.ListNode(5)))));
            var result = RemoveNodeFromTheEnd.RemoveNthFromEnd(input, 2);
            Assert.AreEqual(5, result.next.next.next.val);

            input = new Models.ListNode(1);
            result = RemoveNodeFromTheEnd.RemoveNthFromEnd(input, 1);
            Assert.AreEqual(null, result);

            input = new Models.ListNode(1,
                                        new Models.ListNode(2));
            result = RemoveNodeFromTheEnd.RemoveNthFromEnd(input, 1);
            Assert.AreEqual(1, result.val);
        }
    }
}