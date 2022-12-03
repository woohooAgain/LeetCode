using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestPolindromeBuilder
    {
        public int LongestPalindrome(string s)
        {
            int[] freq = new int[58];
            int odd = 0, maxP = 0;
            foreach (char c in s)
            {
                freq[c - 65]++;
            }
            foreach (var n in freq)
            {
                maxP += n;
                if (n % 2 != 0)
                {
                    maxP--;
                    odd = 1;
                }
            }
            return maxP + odd;
        }
    }
}
