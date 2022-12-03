using LeetCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class ValidateBinaryTreeTests
    {
        [TestMethod()]
        public void IsValidBSTTest()
        {
            var validator = new ValidateBinaryTree();
            var root = new TreeNode(
                5,
                new TreeNode(1),
                new TreeNode(
                    4,
                    new TreeNode(3),
                    new TreeNode(6)));
            var result = validator.IsValidBST(root);
            Assert.IsFalse(result);
            root = new TreeNode(
                2,
                new TreeNode(1),
                new TreeNode(3));
            validator = new ValidateBinaryTree();
            result = validator.IsValidBST(root);
            Assert.IsTrue(result);
            root = new TreeNode(
                2,
                new TreeNode(2),
                new TreeNode(2));
            validator = new ValidateBinaryTree();
            result = validator.IsValidBST(root);
            Assert.IsFalse(result);
            root = new TreeNode(
                5,
                new TreeNode(4),
                new TreeNode(
                    6,
                    new TreeNode(3),
                    new TreeNode(7)));
            validator = new ValidateBinaryTree();
            result = validator.IsValidBST(root);
            Assert.IsFalse(result);
        }
    }
}