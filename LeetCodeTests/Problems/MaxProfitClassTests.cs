using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class MaxProfitClassTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            var prices = new[] { 7, 1, 5, 3, 6, 4 };
            var profit = MaxProfitClass.MaxProfit(prices);
            Assert.AreEqual(5, profit);
            prices = new[] { 2, 4, 1 };
            profit = MaxProfitClass.MaxProfit(prices);
            Assert.AreEqual(2, profit);
            prices = new[] { 2, 5, 1, 3 };
            profit = MaxProfitClass.MaxProfit(prices);
            Assert.AreEqual(3, profit);
        }
    }
}