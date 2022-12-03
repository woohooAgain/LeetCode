using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RepeatedElement
    {
        public static int RepeatedNTimes(int[] nums)
        {
            var length = nums.Length;
            var hash = new HashSet<int>(length);
            for(var i = 0; i < length; i++)
            {
                if (!hash.Add(nums[i]))
                {
                    return nums[i];
                }
            }
            return 0;
        }
    }
}
