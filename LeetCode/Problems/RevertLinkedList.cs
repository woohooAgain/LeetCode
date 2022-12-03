using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RevertLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return new ListNode(head.val);
            }
            var result = ReverseList(head.next);
            var lastNode = result;
            while(lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = new ListNode(head.val);
            return result;
        }
    }
}
