using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interviews
{
    internal class actions_with_graph
    {
        static string[][] paths = new string[][]{
        new []{"B", "K"},
        new []{"C", "K"},
        new []{"E", "L"},
        new []{"F", "G"},
        new []{"J", "M"},
        new []{"E", "F"},
        new []{"G", "H"},
        new []{"G", "I"},
        new []{"C", "G"},
        new []{"A", "B"},
        new []{"A", "C"},
      };
        //A - K, H, I
        //E - L, H, I
        //J - M
        static public List<string> finalLetters = new List<string>();

        public static void MMMMMMain(string[] args)
        {

            var top = new List<string>();
            var next = new List<string>();
            Dictionary<string, List<string>> tails = new Dictionary<string, List<string>>();

            for (int i = 0; i < paths.Length; i++)
            {
                top.Add(paths[i][0]);
            }
            for (int i = 0; i < paths.Length; i++)
            {
                next.Add(paths[i][1]);
            }

            top = top.Distinct().Except(next).ToList();
            for (int i = 0; i < top.Count; i++)
            {
                FindNextLetter(new List<string> { top[i] });
                finalLetters = finalLetters.Distinct().ToList();
                tails.Add(top[i], finalLetters.ToList());
                finalLetters.Clear();
            }
        }

        public static void FindNextLetter(List<string> letters)
        {
            List<string> nextLetters = new List<string>();
            for (int j = 0; j < letters.Count; j++)
            {
                bool existContinuation = false;
                for (int i = 0; i < paths.Length; i++)
                {
                    if (paths[i][0] == letters[j])
                    {
                        existContinuation = true;
                        nextLetters.Add(paths[i][1]);
                    }
                }
                if (!existContinuation)
                {
                    finalLetters.Add(letters[j]);
                }
            }
            if (nextLetters.Count > 0)
            {
                FindNextLetter(nextLetters);
            }
        }
    }
}
