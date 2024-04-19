using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class Gas_Station
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int startIndex = 0;
            int index = 0;
            int lastIndex = gas.Length - 1;
            int tank = 0;
            bool firstInit = true;
            while (true)
            {
                tank = tank + gas[index] - cost[index];

                if (tank > 0 || (tank == 0 && startIndex == (index + 1 > lastIndex ? 0 : index + 1)))
                {
                    if (startIndex == index && firstInit == false)
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
                    firstInit = false;
                }
                else
                {
                    if (startIndex == lastIndex)
                    {
                        return -1;
                    }
                    startIndex++;
                    index = startIndex;
                    tank = 0;
                    firstInit = true;
                }
            }
        }
    }
}
