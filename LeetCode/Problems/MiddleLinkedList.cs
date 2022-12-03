using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MiddleLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var result = head;
            var dict = new Dictionary<int, ListNode>();
            var counter = 1;
            dict[counter] = head;
            while (result.next != null)
            {
                counter++;
                dict[counter] = result.next;
                result = result.next;
            }
            result = dict[counter / 2 + 1];
            return result;
        }
    }
}
