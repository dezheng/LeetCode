using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue && pop > 7)) return 0;
                if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
        public int Reverse2(int x)
        {
            if (x == 0) return 0;
            var negative = x < 0 ? -1 : 1;
            var s = (x * negative).ToString();
            var tmp = new string(s.ToCharArray().Reverse().ToArray());
            if (int.TryParse(tmp, out int result))
                return result * negative;
            else
                return 0;
        }
    }
}
