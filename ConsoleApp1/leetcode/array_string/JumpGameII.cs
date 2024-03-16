using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class JumpGameII
    {
        static int Jump(int[] nums)
        {
            if (nums.Length == 0 || nums[0] == 0)
            {
                return 0;
            }
            if (nums.Length == 1 && nums[0] > 0)
            {
                return 0;
            }
            if (nums[0] >= nums.Length - 1)
            {
                return 1;
            }
            int sizeOfStep = nums[0];
            int sizeOfNextStep = 0;
            int jumps = 1;
            int startIndex = 0;
            int startNextIndex = 0;
            int currStep = 0;
            int i;
            while (true)
            {
                for (i = startIndex + 1; i <= startIndex + sizeOfStep; i++)
                {
                    if (nums[i] + i > currStep)
                    {
                        currStep = nums[i] + i;
                        startNextIndex = i;
                        sizeOfNextStep = nums[i];
                    }
                }
                currStep = 0;
                sizeOfStep = sizeOfNextStep;
                sizeOfNextStep = 0;
                startIndex = startNextIndex;
                startNextIndex = 0;
                jumps++;
                if (startIndex + sizeOfStep >= nums.Length - 1)
                {
                    return jumps;
                }
            }
        }
    }
}
