using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class LongestCommonPrefixClass
    {
        static public string LongestCommonPrefix(string[] strs)
        {
            List<char> prefix = strs[0].ToCharArray().ToList();
            int longOfTheShortestArray = int.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < longOfTheShortestArray)
                {
                    longOfTheShortestArray = strs[i].Length;
                }
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (prefix.Count <= j)
                    {
                        break;
                    }
                    if (prefix[j] != strs[i][j])
                    {
                        prefix.RemoveRange(j, prefix.Count - j);
                    }
                }
            }
            return new string(prefix.Take(longOfTheShortestArray).ToArray());
        }
    }
}
