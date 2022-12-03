using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class SumOfEvenAfterQuery
    {
        public static int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            var qLength = queries.Length;
            var result = new int[qLength];
            var temp = new int[qLength];
            nums.CopyTo(temp, 0);
            for (var i = 0; i < qLength; i++)
            {
                var val = queries[i][0];
                var index = queries[i][1];
                temp[index] += val;
                var tempResult = 0;
                foreach(var t in temp)
                {
                    if (t % 2 == 0)
                    {
                        tempResult += t;
                    }
                }
                result[i] = tempResult;
            }
            return result;
        }
    }
}
