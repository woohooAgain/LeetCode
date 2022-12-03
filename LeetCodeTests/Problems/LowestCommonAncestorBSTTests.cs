using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Models;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class LowestCommonAncestorBSTTests
    {
        [TestMethod()]
        public void LowestCommonAncestorTest()
        {
            var root = new TreeNode(
                6,
                new TreeNode(
                    2,
                    new TreeNode(0),
                    new TreeNode(
                        4,
                        new TreeNode(3),
                        new TreeNode(5)
                    )
                ),
                new TreeNode(
                    8,
                    new TreeNode(7),
                    new TreeNode(9)
                )
            );
            var result = LowestCommonAncestorBST.LowestCommonAncestor(root, new TreeNode(2), new TreeNode(8));
            Assert.AreEqual(6, result.val);
            result = LowestCommonAncestorBST.LowestCommonAncestor(root, new TreeNode(2), new TreeNode(4));
            Assert.AreEqual(2, result.val);
            root = new TreeNode(
                2,
                new TreeNode(1));
            result = LowestCommonAncestorBST.LowestCommonAncestor(root, new TreeNode(2), new TreeNode(1));
            Assert.AreEqual(2, result.val);
        }
    }
}