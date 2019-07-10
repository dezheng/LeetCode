using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length < 3)
            {
                return 0;
            }

            Array.Sort(nums);
            int ans = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int start = i + 1, end = nums.Length - 1;
                while (start < end)
                {
                    int sum = nums[start] + nums[end] + nums[i];
                    if (Math.Abs(target - sum) < Math.Abs(target - ans))
                        ans = sum;
                    if (sum > target)
                        end--;
                    else if (sum < target)
                        start++;
                    else
                        return ans;
                }
            }
            return ans;
        }
    }
}
