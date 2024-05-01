using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.Two_Pointers
{
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var onlySymbols = string.Empty;
            foreach (char c in s.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    onlySymbols += c;
                }
            }
            return onlySymbols == new string(onlySymbols.Reverse().ToArray());
        }
    }
}
