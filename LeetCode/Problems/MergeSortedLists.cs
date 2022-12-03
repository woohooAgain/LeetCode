using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MergeSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            var currentNodeArray = new ListNode[lists.Length];
            for(var i = 0; i < lists.Length; i++)
            {
                currentNodeArray[i] = lists[i];
            }
            var minValueNode = GetNextNode(currentNodeArray);
            var result = minValueNode;
            var currentNode = result;
            while (minValueNode != null)
            {
                minValueNode = GetNextNode(currentNodeArray);
                currentNode.next = minValueNode;
                currentNode = currentNode.next;
            }
            return result;
        }

        private static ListNode GetNextNode(ListNode[] currentNodeArray)
        {
            var length = currentNodeArray.Length;
            int selectedIndex = 0;
            var minValueNode = default(ListNode);
            for (var i = 0; i < length; i++)
            {
                if (currentNodeArray[i] != null)
                {
                    selectedIndex = i;
                    minValueNode = currentNodeArray[i];
                    break;
                }
            }
            if (minValueNode == null)
            {
                return null;
            }
            //var selectedIndex = 0;
            for(var i = 1; i < length; i++)
            {
                if (currentNodeArray[i] != null && currentNodeArray[i].val < minValueNode.val)
                {
                    selectedIndex = i;
                    minValueNode = currentNodeArray[i];
                }
            }
            currentNodeArray[selectedIndex] = currentNodeArray[selectedIndex].next;
            return new ListNode(minValueNode.val);
        }
    }
}
