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
            int tries = 0;
            int gasVolume = 0;
            while (true)
            {
                gasVolume = gasVolume + gas[index] - cost[index];
                if (gasVolume > 0)
                {
                    if (index == lastIndex)
                    {
                        index = 0;
                        gasVolume += gas[index];
                    }
                    else
                    {
                        index++;
                        gasVolume += gas[index];
                    }

                    if (startIndex == index)
                    {
                        return startIndex;
                    }
                }
                else if (gasVolume < 1)
                {
                    if (index == lastIndex)
                    {
                        startIndex = 0;
                        index = 0;
                        gasVolume = 0;
                    }
                    else
                    {
                        startIndex++;
                        index++;
                        gasVolume = 0;
                    }
                    tries++;
                }

                if (tries == gas.Length)
                {
                    return -1;
                }
            }
        }
    }
}
