using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class BinTreeLevelOrder
    {
        public static IList<IList<int>> LevelOrderIter(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var level = new List<int>();
                var size = queue.Count;
                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    level.Add(current.val);
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }
                result.Add(level);
            }
            return result;
        }
    }
}
