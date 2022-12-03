using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LowestCommonAncestorBST
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val > root.val && q.val > root.val)
                return LowestCommonAncestor(root.right, p, q);
            else if (p.val < root.val && q.val < root.val)
                return LowestCommonAncestor(root.left, p, q);

            else return root;
        }
    }
}
