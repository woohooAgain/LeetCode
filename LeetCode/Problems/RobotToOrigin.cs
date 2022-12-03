using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RobotToOrigin
    {
        public static bool JudgeCircle(string moves)
        {
            var steps = new int[4];
            foreach(var m in moves)
            {
                switch (m)
                {
                    case 'R':
                        if (steps[1] == 0)
                        {
                            steps[0]++;
                        }
                        else
                        {
                            steps[1]--;
                        }
                        break;
                    case 'L':
                        if (steps[0] == 0)
                        {
                            steps[1]++;
                        }
                        else
                        {
                            steps[0]--;
                        }
                        break;
                    case 'U':
                        if (steps[3] == 0)
                        {
                            steps[2]++;
                        }
                        else
                        {
                            steps[3]--;
                        }
                        break;
                    case 'D':
                        if (steps[2] == 0)
                        {
                            steps[3]++;
                        }
                        else
                        {
                            steps[2]--;
                        }
                        break;
                    default:
                        throw new Exception();
                }
            }
            var tmp = 0;
            for (var i = 0; i < 4; i++)
            {
                tmp += steps[i];
            }
            return tmp == 0;
        }
    }
}
