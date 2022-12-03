using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class BalancesBinaryTreeTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            var result = BalancesBinaryTree.IsBalanced(
                new Models.TreeNode(3,
                                    new Models.TreeNode(9),
                                    new Models.TreeNode(20,
                                                        new Models.TreeNode(15),
                                                        new Models.TreeNode(7))));
            Assert.IsTrue(result);

            result = BalancesBinaryTree.IsBalanced(
                new Models.TreeNode(1,
                                    new Models.TreeNode(2,
                                                        new Models.TreeNode(3,
                                                                            new Models.TreeNode(4),
                                                                            new Models.TreeNode(4)),
                                                        new Models.TreeNode(3)),
                                    new Models.TreeNode(2)));
            Assert.IsFalse(result);

            result = BalancesBinaryTree.IsBalanced(new Models.TreeNode(1,
                                                                       null,
                                                                       new Models.TreeNode(2,
                                                                                           null,
                                                                                           new Models.TreeNode(3))));
            Assert.IsFalse(result);

            result = BalancesBinaryTree.IsBalanced(new Models.TreeNode(1,
                                                                       new Models.TreeNode(2)));
            Assert.IsTrue(result);

            result = BalancesBinaryTree.IsBalanced(new Models.TreeNode());
            Assert.IsTrue(result);
        }
    }
}