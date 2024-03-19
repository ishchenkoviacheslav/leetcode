using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    public class RandomizedSet
    {
        List<int> values = null;
        static int counter = 0;

        public RandomizedSet()
        {
            values = new List<int>();
        }

        public bool Insert(int val)
        {
            counter = 0;
            if (values.Contains(val))
            {
                return false;
            }
            else
            {
                values.Add(val);
                return true;
            }
        }

        public bool Remove(int val)
        {
            counter = 0;
            return values.Remove(val);
        }

        public int GetRandom()
        {
            int res = values[counter];
            counter++;
            if (counter > values.Count - 1)
            {
                counter = 0;
            }
            return res;
        }
    }
}
