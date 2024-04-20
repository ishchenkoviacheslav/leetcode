using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class Integer_to_Roman
    {
        public string IntToRoman(int num)
        {
            StringBuilder romanNumber = new StringBuilder() { Capacity = 4 };
            var numAsChars = num.ToString().ToCharArray().Reverse().ToArray();
            for (int i = 0; i < numAsChars.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (numAsChars[i] == '1')
                        {
                            romanNumber.Insert(0, "I");
                        }
                        else if (numAsChars[i] == '2')
                        {
                            romanNumber.Insert(0, "II");
                        }
                        else if (numAsChars[i] == '3')
                        {
                            romanNumber.Insert(0, "III");
                        }
                        else if (numAsChars[i] == '4')
                        {
                            romanNumber.Insert(0, "IV");
                        }
                        else if (numAsChars[i] == '5')
                        {
                            romanNumber.Insert(0, "V");
                        }
                        else if (numAsChars[i] == '6')
                        {
                            romanNumber.Insert(0, "VI");
                        }
                        else if (numAsChars[i] == '7')
                        {
                            romanNumber.Insert(0, "VII");
                        }
                        else if (numAsChars[i] == '8')
                        {
                            romanNumber.Insert(0, "VIII");
                        }
                        else if (numAsChars[i] == '9')
                        {
                            romanNumber.Insert(0, "IX");
                        }
                        break;
                    //dozents
                    case 1:
                        if (numAsChars[i] == '1')
                        {
                            romanNumber.Insert(0, "X");
                        }
                        else if (numAsChars[i] == '2')
                        {
                            romanNumber.Insert(0, "XX");
                        }
                        else if (numAsChars[i] == '3')
                        {
                            romanNumber.Insert(0, "XXX");
                        }
                        else if (numAsChars[i] == '4')
                        {
                            romanNumber.Insert(0, "XL");
                        }
                        else if (numAsChars[i] == '5')
                        {
                            romanNumber.Insert(0, "L");
                        }
                        else if (numAsChars[i] == '6')
                        {
                            romanNumber.Insert(0, "LX");
                        }
                        else if (numAsChars[i] == '7')
                        {
                            romanNumber.Insert(0, "LXX");
                        }
                        else if (numAsChars[i] == '8')
                        {
                            romanNumber.Insert(0, "LXXX");
                        }
                        else if (numAsChars[i] == '9')
                        {
                            romanNumber.Insert(0, "XC");
                        }
                        break;
                    //hundreds
                    case 2:
                        if (numAsChars[i] == '1')
                        {
                            romanNumber.Insert(0, "C");
                        }
                        else if (numAsChars[i] == '2')
                        {
                            romanNumber.Insert(0, "CC");
                        }
                        else if (numAsChars[i] == '3')
                        {
                            romanNumber.Insert(0, "CCC");
                        }
                        else if (numAsChars[i] == '4')
                        {
                            romanNumber.Insert(0, "CD");
                        }
                        else if (numAsChars[i] == '5')
                        {
                            romanNumber.Insert(0, "D");
                        }
                        else if (numAsChars[i] == '6')
                        {
                            romanNumber.Insert(0, "DC");
                        }
                        else if (numAsChars[i] == '7')
                        {
                            romanNumber.Insert(0, "DCC");
                        }
                        else if (numAsChars[i] == '8')
                        {
                            romanNumber.Insert(0, "DCCC");
                        }
                        else if (numAsChars[i] == '9')
                        {
                            romanNumber.Insert(0, "CM");
                        }
                        break;
                    //thousands
                    case 3:
                        if (numAsChars[i] == '1')
                        {
                            romanNumber.Insert(0, "M");
                        }
                        else if (numAsChars[i] == '2')
                        {
                            romanNumber.Insert(0, "MM");
                        }
                        else if (numAsChars[i] == '3')
                        {
                            romanNumber.Insert(0, "MMM");
                        }
                        break;
                }
            }

            return romanNumber.ToString();
        }
    }
}
