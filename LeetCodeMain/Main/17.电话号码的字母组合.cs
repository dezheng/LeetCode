using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var dic = new Dictionary<char, string[]>
            {
                {'2', new[] {"a", "b", "c"}},
                {'3', new[] {"d", "e", "f"}},
                {'4', new[] {"g", "h", "i"}},
                {'5', new[] {"j", "k", "l"}},
                {'6', new[] {"m", "n", "o"}},
                {'7', new[] {"p", "q", "r", "s"}},
                {'8', new[] {"t", "u", "v"}},
                {'9', new[] {"w", "x", "y", "z"}}
            };
            var result = new List<string>();
            for (var index = 0; index < digits.Length; index++)
            {
                if (index == 0)
                {
                    result = dic[digits[index]].ToList();
                }
                else
                {
                    result = Do(result, dic[digits[index]]);
                }
            }

            return result;
        }

        private List<string> Do(IList<string> orignal, IList<string> addList)
        {
            var result = new List<string>();
            foreach (var a in orignal)
            {
                foreach (var b in addList)
                {
                    result.Add($"{a}{b}");
                }
            }
            return result;
        }
    }
}
