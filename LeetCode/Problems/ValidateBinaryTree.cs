using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ValidateBinaryTree
    {
        List<int> sortedlist = new List<int>();
        public bool IsValidBST(TreeNode root)
        {
            BuildSortedList(root);

            //Once the inorder traversal is complete, if it;s a valid BST, 
            //then we will have sortedList(nodes are stored in ascending order), 
            //if not, that means it's not a valid BST. 
            for (int i = 0; i < sortedlist.Count - 1; i++)
            {
                if (sortedlist[i] >= sortedlist[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public void BuildSortedList(TreeNode node)
        {
            //Performing Inorder traversal
            if (node == null) return;
            BuildSortedList(node.left);
            sortedlist.Add(node.val);
            BuildSortedList(node.right);
        }
    }
}
