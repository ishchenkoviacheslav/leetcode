using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    public class RandomizedSet
    {
        HashSet<int> set = null;
        Random rnd = null;
        public RandomizedSet()
        {
            set = new HashSet<int>();
            rnd = new Random();
        }

        public bool Insert(int val)
        {
            return set.Add(val);
        }

        public bool Remove(int val)
        {
            return set.Remove(val);
        }

        public int GetRandom()
        {
            return set.ElementAt(rnd.Next(set.Count));
        }
    }
}
