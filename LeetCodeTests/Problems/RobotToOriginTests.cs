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
    public class RobotToOriginTests
    {
        [TestMethod()]
        public void JudgeCircleTest()
        {
            var result = RobotToOrigin.JudgeCircle("UD");
            Assert.IsTrue(result);

            result = RobotToOrigin.JudgeCircle("LL");
            Assert.IsFalse(result);
        }
    }
}