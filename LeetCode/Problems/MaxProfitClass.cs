using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MaxProfitClass
    {
        public static int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            if (prices.Length <= 1)
            {
                return maxProfit;
            }
            var buyPriceIndex = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] - prices[buyPriceIndex] > maxProfit)
                {
                    maxProfit = prices[i] - prices[buyPriceIndex];
                }
                if (prices[i] < prices[buyPriceIndex])
                {
                    buyPriceIndex = i;
                }
            }
            return maxProfit;
        }

        public static int MaxProfit2(int[] prices)
        {
            var maxProfit = 0;
            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > maxProfit)
                    {
                        maxProfit = prices[j] - prices[i];
                    }
                }
            }
            return maxProfit;
        }
    }
}
