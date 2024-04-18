class Program
{
    static public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int startIndex = 0;
        int index = 0;
        int lastIndex = gas.Length - 1;
        int tries = 0;
        int tank = 0;
        bool firstInit = true;
        while (true)
        {
            if (gas[index] - cost[index] < 1 && index == startIndex)
            {
                tank = -1;
            }
            else
            {
                if (firstInit)
                {
                    firstInit = false;
                    tank = gas[index];
                }
                else
                {
                    tank = tank - cost[index-1 < 0 ? lastIndex : index-1] + gas[index];
                }
            }

            if (tank > 0)
            {
                if (startIndex+1 == index)
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
            else if (tank < 1)
            {
                if (index == lastIndex)
                {
                    startIndex = 0;
                    index = 0;
                    tank = 0;
                    firstInit = true;
                }
                else
                {
                    startIndex++;
                    index++;
                    tank = 0;
                    firstInit = true;
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