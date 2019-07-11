using System;
using System.Collections.Generic;

namespace Main
{
    public partial class Solution
    {
        public int[] Trap(int[] height)
        {
            if (height == null || height.Length < 3)
            {
                return null;
            }

            var sum1 = 0;
            var sum2 = 0;
            var m = height[0];
            var array = new List<int>();
            for (int i = 0; i < height.Length; i++)
            {
                sum1 += height[i];
                if (m > 0 && height[i] <= m)
                {
                    sum2 += m; ;
                    array.Add(m);
                }
                else
                {
                    if (height[i] > m)
                        m = height[i];

                    sum2 += height[i];
                    array.Add(height[i]);
                }
            }

            return array.ToArray();
        }
    }
}
