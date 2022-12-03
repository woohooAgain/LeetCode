using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RemoveNodeFromTheEnd
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dict = new Dictionary<int, ListNode>();
            var current = head;
            var counter = 0;
            while(current != null)
            {
                dict.Add(counter++, current);
                current = current.next;
            }
            var index = counter - n;
            if (index != 0)
            {
                if (n == 1)
                {
                    dict[index - 1].next = null;
                }
                else
                {
                    dict[index - 1].next = dict[index + 1];
                }
                return dict[0];
            }
            else
            {
                return head.next;
            }
        }
    }
}
