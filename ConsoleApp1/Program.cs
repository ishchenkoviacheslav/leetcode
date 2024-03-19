class Program
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

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
    static void Main()
    {
        RandomizedSet obj = new RandomizedSet();
        bool param_1 = obj.Insert(1);
       obj.Insert(10);
        obj.Insert(20);
        obj.Insert(30);
        //bool param_2 = obj.Remove(2);
        //obj.Insert(2);
        //int param_3 = obj.GetRandom();
        //obj.Remove(1);
        //obj.Insert(2);
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());

    }
}