using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return result;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    return result;
                if (i > 0 && nums[i] == nums[i - 1]) continue; // 去重
                var balance = 0 - nums[i];
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    var k = j + 1;
                    while (k < nums.Length)
                    {
                        var sum = nums[j] + nums[k];
                        if (sum == balance)
                        {
                            if (nums[j] == nums[j - 1] && j > i + 1)
                            {

                            }
                            else if (nums[k] == nums[k - 1] && k - 1 > j)
                            {

                            }
                            else
                            {
                                result.Add(new List<int> { nums[i], nums[j], nums[k] });
                            }
                            k++;
                        }
                        else if (sum > balance)
                        {
                            break;
                        }
                        else
                        {
                            k++;
                        }
                    }
                }
            }
            return result;
        }


        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return result;
            }
            Array.Sort(nums);
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0) break; // 如果当前数字大于0，则三数之和一定大于0，所以结束循环
                if (i > 0 && nums[i] == nums[i - 1]) continue; // 去重
                int L = i + 1;
                int R = len - 1;
                while (L < R)
                {
                    int sum = nums[i] + nums[L] + nums[R];
                    if (sum == 0)
                    {
                        result.Add(new List<int>(3) { nums[i], nums[L], nums[R] });
                        while (L < R && nums[L] == nums[L + 1]) L++; // 去重
                        while (L < R && nums[R] == nums[R - 1]) R--; // 去重
                        L++;
                        R--;
                    }
                    else if (sum < 0) L++;
                    else if (sum > 0) R--;
                }
            }
            return result;
        }
    }
}
