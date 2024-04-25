using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interviews
{
    internal class AnagramClass
    {
        //Console.WriteLine(Anagram("aa", "ba"));
        //Console.WriteLine(Anagram("ba", "aa"));
        //Console.WriteLine(Anagram("anagram", "aganmar"));
        //Console.WriteLine(Anagram("aaagram", "aganmar"));
        bool Anagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            //another method is order both char arrays and compare element by element in for.
            //bur performance of ordering is minus of this approach
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();

            var bChars = b.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (charDictionary.ContainsKey(a[i]))
                {
                    charDictionary[a[i]]++;
                }
                else
                {
                    charDictionary.Add(a[i], 1);
                }
            }

            for (int i = 0; i < bChars.Length; i++)
            {
                if (!charDictionary.ContainsKey(bChars[i]))
                {
                    return false;
                }
                else
                {
                    charDictionary[bChars[i]]--;
                }
            }

            foreach (int count in charDictionary.Values)
            {
                if (count != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
