using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.Two_Pointers
{
    internal class IsSubsequenceClass
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }
            for (int i = 0, j = 0; i < t.Length && j < s.Length; i++)
            {
                if (s[j] == t[i])
                {
                    if (j == s.Length - 1)
                    {
                        return true;
                    }
                    j++;
                }
            }

            return false;
        }
    }
}
