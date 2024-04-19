class Program
{
    static public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int startIndex = 0;
        int index = 0;
        int lastIndex = gas.Length - 1;
        int tries = 1;
        int tank = 0;
        while (true)
        {
            tank = tank + gas[index] - cost[index];

            if (tank > 0)
            {
                if (startIndex == index)
                {
                    return startIndex;
                }
                if (index == lastIndex)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else
            {
                if (index == lastIndex)
                {
                    startIndex = 0;
                    index = 0;
                    tank = 0;
                }
                else
                {
                    startIndex++;
                    index = startIndex;
                    tank = 0;
                }
                tries++;
            }

            if (tries == gas.Length)
            {
                return -1;
            }
        }
    }
    static void Main()
    {
        //Console.WriteLine(CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }));
        //Console.WriteLine(CanCompleteCircuit(new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 }));
        Console.WriteLine(CanCompleteCircuit(new int[] { 5, 1, 2, 3, 4 }, new int[] { 4, 4, 1, 5, 1 }));
    }
}