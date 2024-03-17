using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class RomanToInteger
    {
        static int RomanToInt(string s)
        {
            int res = 0;
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'I':
                        if (i + 1 < chars.Length && chars[i + 1] == 'V')
                        {
                            res += 4;
                            i++;
                        }
                        else if (i + 1 < chars.Length && chars[i + 1] == 'X')
                        {
                            res += 9;
                            i++;
                        }
                        else
                        {
                            res += 1;
                        }
                        break;
                    case 'V':
                        res += 5;
                        break;
                    case 'X':
                        if (i + 1 < chars.Length && chars[i + 1] == 'L')
                        {
                            res += 40;
                            i++;
                        }
                        else if (i + 1 < chars.Length && chars[i + 1] == 'C')
                        {
                            res += 90;
                            i++;
                        }
                        else
                        {
                            res += 10;
                        }
                        break;
                    case 'L':
                        res += 50;
                        break;
                    case 'C':
                        if (i + 1 < chars.Length && chars[i + 1] == 'D')
                        {
                            res += 400;
                            i++;
                        }
                        else if (i + 1 < chars.Length && chars[i + 1] == 'M')
                        {
                            res += 900;
                            i++;
                        }
                        else
                        {
                            res += 100;
                        }
                        break;
                    case 'D':
                        res += 500;
                        break;
                    case 'M':
                        res += 1000;
                        break;
                }
            }
            return res;
        }
    }
}
