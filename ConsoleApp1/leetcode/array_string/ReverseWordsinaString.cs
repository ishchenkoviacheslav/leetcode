using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class ReverseWordsinaString
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).Reverse().ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                if (i < words.Length - 1)
                {
                    sb.Append(words[i] + " ");
                }
                else
                {
                    sb.Append(words[i]);
                }
            }

            return sb.ToString();
        }
    }
}
