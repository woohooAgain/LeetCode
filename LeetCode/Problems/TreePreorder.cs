using LeetCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class TreePreorder
    {
        public static IList<int> PreorderRecur(Node root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            var result = new List<int>();
            result.Add(root.val);
            if (root.children != null)
            {
                foreach(var c in root.children)
                {
                    result.AddRange(PreorderRecur(c));
                }
            }
            return result;
        }

        public static IList<int> PreorderIter(Node root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            var result = new List<int>();
            var stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                result.Add(node.val);
                if (node.children == null)
                {
                    continue;
                }
                for(var i = node.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(node.children[i]);
                }
            }
            return result;
        }
    }
}
