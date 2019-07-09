namespace Main
{
    public partial class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            switch (strs.Length)
            {
                case 0:
                    return "";
                case 1:
                    return strs[0];
            }

            var i = 1;
            var result = "";
            while (true)
            {
                var thisResult = "";
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Length < i)
                    {
                        return result;
                    }
                    if (j == 0)
                    {
                        thisResult = strs[j].Substring(0, i);
                    }
                    else if (thisResult != strs[j].Substring(0, i))
                    {
                        return result;
                    }
                    else if (j == strs.Length - 1)
                    {
                        result = thisResult;
                        i++;
                    }
                }
            }

        }
        public string LongestCommonPrefix2(string[] strs)
        {
            switch (strs.Length)
            {
                case 0:
                    return "";
                case 1:
                    return strs[0];
            }

            var result = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                var prefix = strs[0].Substring(0, 1 + i);
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length < i+1)
                    {
                        return result;
                    }

                    if (strs[j].Substring(0, i + 1) != prefix)
                    {
                        return result;
                    }
                }
                result = prefix;
            }

            return result;
        }
    }
}
