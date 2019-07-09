using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        //  罗马数字包含以下七种字符： I， V， X， L，C，D 和 M。
        //  
        //  字符          数值
        //  I             1
        //  V             5
        //  X             10
        //  L             50
        //  C             100
        //  D             500
        //  M             1000
        //  例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做  XXVII, 即为 XX + V + II 。
        //  
        //  通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：
        //  
        //  I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
        //  X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。 
        //  C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
        //  给定一个整数，将其转为罗马数字。输入确保在 1 到 3999 的范围内。
        //  
        //  示例 1:
        //  
        //  输入: 3
        //  输出: "III"
        //  示例 2:
        //  
        //  输入: 4
        //  输出: "IV"
        //  示例 3:
        //  
        //  输入: 9
        //  输出: "IX"
        //  示例 4:
        //  
        //  输入: 58
        //  输出: "LVIII"
        //  解释: L = 50, V = 5, III = 3.
        //  示例 5:
        //  
        //  输入: 1994
        //  输出: "MCMXCIV"
        //  解释: M = 1000, CM = 900, XC = 90, IV = 4.
        public string IntToRoman(int num)
        {
            //DCCCC  ----CM 900
            //CCCC   ----CD 400
            //LXXXX  ----XC 90
            //XXXX   ----XL 40
            //VIIII  ----IX 9
            //IIII   ----IV 4
            if (num > 3999 || num < 1)
            {
                return null;
            }

            var result = string.Empty;
            var mCount = num / 1000; num = num % 1000;
            for (int i = 0; i < mCount; i++)
            {
                result += "M";
            }
            var dCount = num / 500; num = num % 500;
            for (int i = 0; i < dCount; i++)
            {
                result += "D";
            }
            var cCount = num / 100; num = num % 100;
            for (int i = 0; i < cCount; i++)
            {
                result += "C";
            }
            var lCount = num / 50; num = num % 50;
            for (int i = 0; i < lCount; i++)
            {
                result += "L";
            }
            var xCount = num / 10; num = num % 10;
            for (int i = 0; i < xCount; i++)
            {
                result += "X";
            }
            var vCount = num / 5; num = num % 5;
            for (int i = 0; i < vCount; i++)
            {
                result += "V";
            }
            var count = num / 1; num = num % 1;
            for (int i = 0; i < count; i++)
            {
                result += "I";
            }

            return result.Replace("DCCCC", "CM").Replace("CCCC", "CD").Replace("LXXXX", "XC").Replace("XXXX", "XL")
                .Replace("VIIII", "IX").Replace("IIII", "IV");
        }

        public string IntToRomanBetter(int num)
        {
            //用数组定义字典
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] strs = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            //定义一个字符串
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                int a = num / values[i];
                if (a == 0) continue;
                for (int j = a; j > 0; j--)
                    res.Append(strs[i]);
                num -= (a * values[i]);
                if (num == 0) break;
            }
            return res.ToString();


        }
    }
}
