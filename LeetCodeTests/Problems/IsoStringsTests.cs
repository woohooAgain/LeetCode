using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Problems
{
    [TestClass()]
    public class IsoStringsTests
    {
        [TestMethod()]
        public void IsIsomorphicTest()
        {
            var isoStrings = new IsoStrings();
            Assert.IsTrue(isoStrings.IsIsomorphic("egg", "add"));
            Assert.IsFalse(isoStrings.IsIsomorphic("foo", "bar"));
            Assert.IsTrue(isoStrings.IsIsomorphic("paper", "title"));
            Assert.IsFalse(isoStrings.IsIsomorphic("badc", "baba"));
        }
    }
}