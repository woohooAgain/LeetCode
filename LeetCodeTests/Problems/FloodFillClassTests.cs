using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class FloodFillClassTests
    {
        [TestMethod()]
        public void FloodFillTest()
        {
            var image = new int[][] { new[]  { 1, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 1 } };
            var result = FloodFillClass.FloodFill(image, 1, 1, 2);
            Assert.AreEqual(2, result[0][0]);
            Assert.AreEqual(2, result[0][1]);
            Assert.AreEqual(2, result[0][2]);
            Assert.AreEqual(2, result[1][0]);
            Assert.AreEqual(2, result[1][1]);
            Assert.AreEqual(0, result[1][2]);
            Assert.AreEqual(2, result[2][0]);
            Assert.AreEqual(0, result[2][1]);
            Assert.AreEqual(1, result[2][2]);
            
            image = new int[][] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } };
            result = FloodFillClass.FloodFill(image, 0, 0, 0);
            Assert.AreEqual(0, result[0][0]);
            Assert.AreEqual(0, result[0][1]);
            Assert.AreEqual(0, result[0][2]);
            Assert.AreEqual(0, result[1][0]);
            Assert.AreEqual(0, result[1][1]);
            Assert.AreEqual(0, result[1][2]);

            image = new int[][] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } };
            result = FloodFillClass.FloodFill(image, 1, 0, 2);
            Assert.AreEqual(2, result[0][0]);
            Assert.AreEqual(2, result[0][1]);
            Assert.AreEqual(2, result[0][2]);
            Assert.AreEqual(2, result[1][0]);
            Assert.AreEqual(2, result[1][1]);
            Assert.AreEqual(2, result[1][2]);
        }
    }
}