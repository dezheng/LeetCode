using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            var length = height.Length;
            var start = 0;
            var end = length - 1;
            while (end > start)
            {
                max = Math.Max(max, Math.Min(height[start], height[end]) * (end - start));
                if (height[start] > height[end])
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return max;
        }
    }
}
