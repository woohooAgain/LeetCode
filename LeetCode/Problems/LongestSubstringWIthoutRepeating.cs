using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestSubstringWithoutRepeating
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var queue = new Queue<char>(s.Length);
            var max = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (queue.Contains(c))
                {
                    max = max > queue.Count ? max : queue.Count;
                    while (queue.Contains(c))
                    {
                        queue.Dequeue();
                    }
                }
                queue.Enqueue(c);
            }
            return max > queue.Count ? max : queue.Count;
        }
    }
}
