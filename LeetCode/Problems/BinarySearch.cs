using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;
            int mid;            
            while (low != high)
            {
                mid = (low + high) / 2;
                var guess = nums[mid];
                if (guess == target)
                {
                    return mid;
                }
                if (guess <= target)
                {
                    low = mid == nums.Length - 1 ? nums.Length : mid + 1;
                }
                else
                {
                    high = mid == 0 ? 0 : mid - 1;
                }
            }
            if (nums[low] == target)
            {
                return low;
            }
            return -1;
        }
    }
}
