using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LinkedListCycle
    {
        public static ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode result = null;
            var visited = new HashSet<ListNode>();
            visited.Add(head);
            while (head.next != null)
            {
                if (!visited.Add(head.next))
                {
                    return head.next;
                }
                head = head.next;
            }
            return result;
        }
    }
}
