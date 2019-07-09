namespace Main
{
    public partial class Solution
    {
        public int RomanToInt(string s)
        {
            var array = s.Replace("CM", "DCCCC")
                .Replace("CD", "CCCC")
                .Replace("XC", "LXXXX")
                .Replace("XL", "XXXX")
                .Replace("IX", "VIIII")
                .Replace("IV", "IIII").ToCharArray();
            var result = 0;
            foreach (var item in array)
            {
                if (item == 'I') { result += 1; }
                if (item == 'V') { result += 5; }
                if (item == 'X') { result += 10; }
                if (item == 'L') { result += 50; }
                if (item == 'C') { result += 100; }
                if (item == 'D') { result += 500; }
                if (item == 'M') { result += 1000; }
            }

            return result;
        }
    }
}
