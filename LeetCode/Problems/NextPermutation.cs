using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class NextPermutation
    {
        public static void NextPermutationAction(int[] nums)
        {
            var i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {
                var j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1);
        }

        private static void Reverse(int[] nums, int start)
        {
            var i = start;
            var j = nums.Length - 1;
            while(i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }    
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
