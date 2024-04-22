using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            StringBuilder[] rows = new StringBuilder[numRows];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new StringBuilder();
            }

            Queue<char> asChars = new Queue<char>(s.ToCharArray());
            int j = 0;
            bool zigzagSymbols = false;
            int counter = asChars.Count;
            for (int i = 0; i < counter;)
            {
                if (zigzagSymbols && j < numRows - 1 && j > 0)
                {
                    rows[numRows - 1 - j].Append(asChars.Dequeue());
                    i++;
                }
                else if (zigzagSymbols == false)
                {
                    rows[j].Append(asChars.Dequeue());
                    i++;
                }
                j++;

                if (j == numRows)
                {
                    zigzagSymbols = zigzagSymbols ? false : true;
                    j = 0;
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < rows.Length; i++)
            {
                result.Append(rows[i]);
            }

            return result.ToString();
        }
    }
}
