using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class LengthofLastWord
    {
        static public int LengthOfLastWord(string s)
        {
            char[] chars = s.Trim().ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == ' ')
                {
                    return chars.Length - 1 - i;
                }
            }

            return chars.Length;
        }
    }
}
