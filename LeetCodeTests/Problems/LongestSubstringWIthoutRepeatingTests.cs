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
    public class LongestSubstringWithoutRepeatingTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            var result = LongestSubstringWithoutRepeating.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, result);

            result = LongestSubstringWithoutRepeating.LengthOfLongestSubstring("bbbbb");
            Assert.AreEqual(1, result);

            result = LongestSubstringWithoutRepeating.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(3, result);

            result = LongestSubstringWithoutRepeating.LengthOfLongestSubstring("dvdf");
            Assert.AreEqual(3, result);
        }
    }
}