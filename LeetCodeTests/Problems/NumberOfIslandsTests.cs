using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class NumberOfIslandsTests
    {
        [TestMethod()]
        public void NumIslandsTest()
        {
            var islandCounter = new NumberOfIslands();
            var grid = new char[][]{ new char[] { '1', '1', '1', '1', '0' },
                                     new char[] { '1', '1', '0', '1', '0' },
                                     new char[] { '1', '1', '0', '0', '0' },
                                     new char[] { '0', '0', '0', '0', '0' }};
            var result = islandCounter.NumIslands(grid);
            Assert.AreEqual(1, result);

            grid = new char[][]{ new char[] { '1', '1', '0', '0', '0' },
                                 new char[] { '1', '1', '0', '0', '0' },
                                 new char[] { '0', '0', '1', '0', '0' },
                                 new char[] { '0', '0', '0', '1', '1' }};
            result = islandCounter.NumIslands(grid);
            Assert.AreEqual(3, result);

            grid = new char[][]{ new char[] { '1', '1', '1' },
                                 new char[] { '0', '1', '0' },
                                 new char[] { '1', '1', '1' }};
            result = islandCounter.NumIslands(grid);
            Assert.AreEqual(1, result);
        }
    }
}