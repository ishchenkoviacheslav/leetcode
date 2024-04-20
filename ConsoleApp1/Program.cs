using System.Diagnostics;
using System.Text;

class Program
{
    static public string IntToRoman(int num)
    {
        StringBuilder romanNumber = new StringBuilder() { Capacity = 4 };
        var numAsChars = num.ToString().ToCharArray();
        for (int i = numAsChars.Length - 1; i > -1; i--)
        {
            switch (i)
            {
                case 0:
                    if (numAsChars[i] == 1)
                    {
                        romanNumber.Append("I");
                    }
                    else if (numAsChars[i] == 2)
                    {
                        romanNumber.Append("II");
                    }
                    else if (numAsChars[i] == 3)
                    {
                        romanNumber.Append("III");
                    }
                    else if (numAsChars[i] == 4)
                    {
                        romanNumber.Append("IV");
                    }
                    else if (numAsChars[i] == 5)
                    {
                        romanNumber.Append("V");
                    }
                    else if (numAsChars[i] == 6)
                    {
                        romanNumber.Append("VI");
                    }
                    else if (numAsChars[i] == 7)
                    {
                        romanNumber.Append("VII");
                    }
                    else if (numAsChars[i] == 8)
                    {
                        romanNumber.Append("VIII");
                    }
                    else if (numAsChars[i] == 9)
                    {
                        romanNumber.Append("IX");
                    }
                    break;
                //dozents
                case 1:
                    if (numAsChars[i] == 1)
                    {
                        romanNumber.Append("X");
                    }
                    else if (numAsChars[i] == 2)
                    {
                        romanNumber.Append("XX");
                    }
                    else if (numAsChars[i] == 3)
                    {
                        romanNumber.Append("XXX");
                    }
                    else if (numAsChars[i] == 4)
                    {
                        romanNumber.Append("XL");
                    }
                    else if (numAsChars[i] == 5)
                    {
                        romanNumber.Append("L");
                    }
                    else if (numAsChars[i] == 6)
                    {
                        romanNumber.Append("LX");
                    }
                    else if (numAsChars[i] == 7)
                    {
                        romanNumber.Append("LXX");
                    }
                    else if (numAsChars[i] == 8)
                    {
                        romanNumber.Append("LXXX");
                    }
                    else if (numAsChars[i] == 9)
                    {
                        romanNumber.Append("XC");
                    }
                    break;
                //hundreds
                case 2:
                    if (numAsChars[i] == 1)
                    {
                        romanNumber.Append("C");
                    }
                    else if (numAsChars[i] == 2)
                    {
                        romanNumber.Append("CC");
                    }
                    else if (numAsChars[i] == 3)
                    {
                        romanNumber.Append("CCC");
                    }
                    else if (numAsChars[i] == 4)
                            {
                        romanNumber.Append("CD");
                    }
                    else if (numAsChars[i] == 5)
                    {
                        romanNumber.Append("D");
                    }
                    else if (numAsChars[i] == 6)
                    {
                        romanNumber.Append("DC");
                    }
                    else if (numAsChars[i] == 7)
                    {
                        romanNumber.Append("DCC");
                    }
                    else if (numAsChars[i] == 8)
                    {
                        romanNumber.Append("DCCC");
                    }
                    else if (numAsChars[i] == 9)
                    {
                        romanNumber.Append("CM");
                    }
                    break;
                //thousands
                case 3:
                    romanNumber.Append("M");
                    break;
            }
        }

        return romanNumber.ToString();
    }
    static void Main()
    {
        Console.WriteLine(IntToRoman(3)); // III
        Console.WriteLine(IntToRoman(58)); // LVIII
        Console.WriteLine(IntToRoman(1994)); // MCMXCIV
    }
}