using LeetCode.Models;

namespace LeetCode.Problems
{
    public class BalancesBinaryTree
    {
        public static bool IsBalanced(TreeNode root)
        {
            int result = IsBalancedAddition(root);
            if (result >= 0)
            {
                return true;
            }
            return false;
        }

        private static int IsBalancedAddition(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var lh = IsBalancedAddition(root.left);
            if (lh == -1)
            {
                return -1;
            }
            var rh = IsBalancedAddition(root.right);
            if (rh == -1)
            {
                return -1;
            }
            if (lh > rh + 1 || rh > lh + 1)
            {
                return -1;
            }
            return Math.Max(lh, rh) + 1;
        }
    }
}
