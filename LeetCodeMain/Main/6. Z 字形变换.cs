using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    //  将一个给定字符串根据给定的行数，以从上往下、从左到右进行 Z 字形排列。
    //  
    //  比如输入字符串为 "LEETCODEISHIRING" 行数为 3 时，排列如下：
    //  
    //  L   C   I   R
    //  E T O E S I I G
    //  E   D   H   N
    //  之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："LCIRETOESIIGEDHN"。
    //  
    //  请你实现这个将字符串进行指定行数变换的函数：
    //  
    //  string convert(string s, int numRows);
    //  示例 1:
    //  
    //  输入: s = "LEETCODEISHIRING", numRows = 3
    //  输出: "LCIRETOESIIGEDHN"
    //  示例 2:
    //  
    //  输入: s = "LEETCODEISHIRING", numRows = 4
    //  输出: "LDREOEIIECIHNTSG"
    //  解释:
    //  
    //  L     D     R
    //  E   O E   I I
    //  E C   I H   N
    //  T     S     G

    public partial class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            var totalCount = s.Length;
            var set = new HashSet<int>(totalCount);

            //m行n列
            var m = numRows;
            var sb = new StringBuilder();
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= totalCount; j++)
                {
                    var a = 2 * (j - 1) * (m - 1) + 2 - i;
                    var b = 2 * (j - 1) * (m - 1) + i;
                    if (a > totalCount)
                    {
                        break;
                    }
                    if (a > 0 && !set.Contains(a))
                    {
                        set.Add(a);
                        sb.Append(s[a - 1]);
                    }

                    if (b > totalCount)
                    {
                        break;
                    }
                    if (b > 0 && !set.Contains(b))
                    {
                        set.Add(b);
                        sb.Append(s[b - 1]);
                    }
                }
            }
            return sb.ToString();
        }

        //第i行差为2*（n-1-i） 2*(i-1)
        public string ConvertOther(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (s.Length == 1 || s.Length <= numRows || numRows == 1)
                return s;
            var oldArray = s.ToCharArray();
            var length = s.Length;
            var array = new char[length];
            var index = 0;
            var sum = 2 * (numRows - 1);
            for (int i = 0; i < numRows; i++)
            {
                array[index++] = oldArray[i];
                var first = sum - 2 * i;
                var second = 2 * (i);
                var thisFirstVal = i;
                while (thisFirstVal < length)
                {
                    if (first > 0)
                    {
                        thisFirstVal += first;
                        if (thisFirstVal < length)
                        {
                            array[index++] = oldArray[thisFirstVal];
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (second > 0)
                    {
                        thisFirstVal += second;
                        if (thisFirstVal < length)
                        {
                            array[index++] = oldArray[thisFirstVal];
                        }
                    }
                }
            }

            return new string(array);
        }
        public string ConvertBetter(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            else if (s.Length == 1 || s.Length <= numRows || numRows == 1)
            {
                return s;
            }


            int sum = numRows * 2 - 2;
            char[] cs = s.ToCharArray();
            char[] arr = new char[cs.Length];
            int index = 0;
            for (int i = 0; i < numRows; i++)
            {
                arr[index++] = cs[i];
                int j = sum - i * 2;
                if (j == 0)
                {
                    j = sum - j;
                }
                int tmpindex = i + j;
                while (tmpindex < cs.Length && index < arr.Length)
                {
                    arr[index++] = cs[tmpindex];
                    j = sum - j;
                    if (j == 0)
                    {
                        j = sum - j;
                    }
                    tmpindex += j;
                }
            }
            return new string(arr);
        }
    }
}
