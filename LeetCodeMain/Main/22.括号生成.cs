using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            return Enumerable.Range(Enumerable.Range(0, n).Aggregate(0, (acc, i) => acc |= 1 << (2 * i + 1)),
                    n == 0 ? 0 : (1 << 2 * n) - (1 << n) - Enumerable.Range(0, n).Aggregate(0, (acc, i) => acc |= 1 << (2 * i + 1)) + 1)
                .Where(num => Enumerable.Range(0, 2 * n).Aggregate(0, (last, i) => last < 0 ? last : last + ((num >> i & 1) == 0 ? 1 : -1), value => value == 0))
                .Select(num => System.Convert.ToString(num, 2).Replace('1', '(').Replace('0', ')')).ToList();

        }
    }
}
