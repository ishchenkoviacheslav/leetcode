using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interviews
{
    internal class Balanced_brackets
    {
        //((())) - BALANCED
        //({[]}) - BALANCED
        //([) - NOT BALANCED
        //([)] - NOT BALANCED
        //([]) - BALANCED
        //)(

        static bool IsBalanced(string s)
        {
            var chars = s.ToCharArray();
            int balancerRound = 0;
            int balancerCurve = 0;
            int balancerSquare = 0;
            string unexpectedSymbols = string.Empty;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(' || chars[i] == ')')
                {
                    if (unexpectedSymbols.Contains(chars[i]))
                    {
                        return false;
                    }
                    if (chars[i] == '(')
                    {
                        unexpectedSymbols = "]}";
                        balancerRound++;
                    }
                    if (chars[i] == ')')
                    {
                        balancerRound--;
                        unexpectedSymbols = string.Empty;
                    }
                }
                //***************************************
                if (chars[i] == '{' || chars[i] == '}')
                {
                    if (unexpectedSymbols.Contains(chars[i]))
                    {
                        return false;
                    }
                    if (chars[i] == '{')
                    {
                        unexpectedSymbols = ")]";
                        balancerCurve++;
                    }
                    if (chars[i] == '}')
                    {
                        balancerCurve--;
                        unexpectedSymbols = string.Empty;
                    }
                }
                //***************************************
                if (chars[i] == '[' || chars[i] == ']')
                {
                    if (unexpectedSymbols.Contains(chars[i]))
                    {
                        return false;
                    }
                    if (chars[i] == '[')
                    {
                        unexpectedSymbols = ")}";
                        balancerSquare++;
                    }
                    if (chars[i] == ']')
                    {
                        balancerSquare--;
                        unexpectedSymbols = string.Empty;
                    }
                }

                if (balancerRound < 0 || balancerCurve < 0 || balancerSquare < 0)
                {
                    return false;
                }
            }

            return balancerRound == 0 && balancerCurve == 0 && balancerSquare == 0;
        }
        //static void Main()
        //{
        //    Console.WriteLine(IsBalanced("((()))")); //T
        //    Console.WriteLine(IsBalanced("({[]})")); //T
        //    Console.WriteLine(IsBalanced("([)"));//F
        //    Console.WriteLine(IsBalanced("([)]")); //F
        //    Console.WriteLine(IsBalanced("([])")); //T
        //    Console.WriteLine(IsBalanced(")(")); //F
        //}
    }
}
