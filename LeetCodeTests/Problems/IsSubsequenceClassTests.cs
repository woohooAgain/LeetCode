using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Problems
{
    [TestClass()]
    public class IsSubsequenceClassTests
    {
        [TestMethod()]
        public void IsSubsequenceTest()
        {
            var isSubClass = new IsSubsequenceClass();
            Assert.IsTrue(isSubClass.IsSubsequence("abc", "ahbgdc"));
            Assert.IsFalse(isSubClass.IsSubsequence("axc", "ahbgdc"));
            Assert.IsFalse(isSubClass.IsSubsequence("aaaaaa", "bbaaaa"));
        }
    }
}