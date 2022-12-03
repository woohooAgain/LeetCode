using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class FloodFillClass
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color)
            {
                return image;
            }
            var result = image;
            var originColor = result[sr][sc];
            result[sr][sc] = color;
            if (sr < image.Length - 1 && result[sr + 1][sc] == originColor)
            {
                result = FloodFill(result, sr + 1, sc, color);
            }
            if (sc < image[0].Length - 1 && result[sr][sc + 1] == originColor)
            {
                result = FloodFill(result, sr, sc + 1, color);
            }
            if (sr > 0 && result[sr - 1][sc] == originColor)
            {
                result = FloodFill(result, sr - 1, sc, color);
            }
            if (sc > 0 && result[sr][sc - 1] == originColor)
            {
                result = FloodFill(result, sr, sc - 1, color);
            }
            return result;
        }
    }
}
