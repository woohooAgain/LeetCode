using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class SubarraySumClass
    {
        public int SubarraySum(int[] nums, int k)
        {
            var result = 0;
            var cache = new Dictionary<int, int>();
            var current = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                current += nums[i];
                if (current == k)
                {
                    result++;
                }

                var key = current > k ? current - k : k - current;

                if (cache.ContainsKey(current - k))
                {
                    result += cache[current - k];
                }

                if (cache.ContainsKey(current))
                {
                    cache[current]++;
                }
                else
                {
                    cache.Add(current, 1);
                }
            }
            return result;
        }
    }
}