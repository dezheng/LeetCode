using System.Collections.Generic;

namespace Main
{
    public partial class Solution
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            if (s.Length % 2 != 0)
                return false;
            var stack = new Stack<char>(s.Length);
            var a = new Dictionary<char, char>
            {
                {'[',']' },
                {'{','}' },
                {'(',')' }
            };
            foreach (var t in s)
            {
                if (a.ContainsKey(t))
                {
                    stack.Push(t);
                }
                else if (stack.Count > 0 && a[stack.Peek()] == t)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
