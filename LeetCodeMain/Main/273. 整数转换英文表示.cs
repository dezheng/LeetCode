using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public partial class Solution
    {
        public string NumberToWords(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }
            var result = new List<string>();
            var billions = num / 1000000000;
            num %= 1000000000;
            if (billions > 0)
            {
                result.Add(NumberToWordsBelowThousand(billions));
                result.Add("Billion");
            }

            var millions = num / 1000000;
            num %= 1000000;
            if (millions > 0)
            {
                result.Add(NumberToWordsBelowThousand(millions));
                result.Add("Million");
            }

            var thousands = num / 1000;
            num %= 1000;
            if (thousands > 0)
            {
                result.Add(NumberToWordsBelowThousand(thousands));
                result.Add("Thousand");
            }

            if (num>0)
            {
                result.Add(NumberToWordsBelowThousand(num));
            }
            return string.Join(" ", result);
        }

        public string NumberToWordsBelowThousand(int num)
        {
            var firstArray = new string[]
            {
               "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            };
            var secondArray = new string[]
            {
                "Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety"
            };
            if (num >= 1000 || num < 1)
            {
                return null;
            }

            var result = new List<string>(4);
            var hundreds = num / 100;
            num %= 100;
            if (hundreds > 0)
            {
                result.Add(firstArray[hundreds]);
                result.Add("Hundred");
            }

            if (num >= 20)
            {
                var tens = num / 10;
                num %= 10;
                result.Add(secondArray[tens - 2]);
                if (num > 0)
                {
                    result.Add(firstArray[num]);
                }
            }
            else if (num > 0)
            {
                result.Add(firstArray[num]);
            }

            return string.Join(" ", result);
        }
    }
}
