using System.Collections.Generic;

namespace Main
{
    public partial class Solution
    {
        //给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

        //示例 1:

        //输入: "abcabcbb"
        //输出: 3 
        //解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
        //示例 2:

        //输入: "bbbbb"
        //输出: 1
        //解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。


        //输入: "pwwkew"
        //输出: 3
        //解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
        //请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
        public int LengthOfLongestSubstring(string s)
        {
            var list = new List<char>();
            var maxCount = 0;
            foreach (var t in s)
            {
                if (!list.Contains(t))
                {
                    list.Add(t);
                    if (list.Count > maxCount)
                    {
                        maxCount = list.Count;
                    }
                }
                else
                {
                    list.RemoveRange(0, list.IndexOf(t) + 1);
                    list.Add(t);
                }
            }

            return maxCount;
        }
    }
}
