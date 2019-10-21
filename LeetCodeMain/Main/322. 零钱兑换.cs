using System;
using System.Linq;

namespace Main
{
    public partial class Solution
    {
        //给定不同面额的硬币 coins 和一个总金额 amount。编写一个函数来计算可以凑成总金额所需的最少的硬币个数。如果没有任何一种硬币组合能组成总金额，返回 -1。

        //示例 1:

        //输入: coins = [1, 2, 5], amount = 11
        //输出: 3 
        //解释: 11 = 5 + 5 + 1
        //示例 2:

        //输入: coins = [2], amount = 3
        //输出: -1

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/coin-change
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int CoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, max);
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                foreach (var t in coins)
                {
                    if (t <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - t] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }
        //给定一个无序的整数数组，找到其中最长上升子序列的长度。

        //示例:

        //输入: [10,9,2,5,3,7,101,18]
        //输出: 4 
        //解释: 最长的上升子序列是[2, 3, 7, 101]，它的长度是 4。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/longest-increasing-subsequence
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            var dp = new int[nums.Length];
            Array.Fill(dp, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            return dp.Max();
        }
    }
}
