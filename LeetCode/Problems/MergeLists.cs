using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }
            ListNode result;
            if (list1.val > list2.val)
            {
                result = new ListNode(list2.val, MergeTwoLists(list1, list2.next));               
            }
            else
            {
                result = new ListNode(list1.val, MergeTwoLists(list2, list1.next));
            }
            return result;
        }
    }
}
