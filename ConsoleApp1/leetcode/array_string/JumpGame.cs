using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class JumpGame
    {
        //((())) - BALANCED
        //({[]}) - BALANCED
        //([) - NOT BALANCED
        //([)] - NOT BALANCED
        //([]) - BALANCED
        //)(

        static bool CanJump(int[] nums)
        {
            if (nums.Length == 1 || nums.Length == nums[0])
            {
                return true;
            }
            if (nums[0] == 0)
            {
                return false;
            }
            int indexToMove = 0;
            int jump = 0;
            while (true)
            {
                if (nums.Length - 1 < jump + indexToMove)
                {
                    return true;
                }
                int counter = nums[indexToMove];
                int currentMaxJump = jump + counter;
                for (int i = jump; i < currentMaxJump; i++)
                {
                    if (nums[i] > indexToMove)
                    {
                        //take it as value, but use it as index
                        indexToMove = nums[i];
                        jump++;
                    }
                    if (currentMaxJump - jump == 1)
                    {
                        indexToMove = nums[i];
                        jump++;
                    }
                }

                if (counter == 0)
                {
                    return false;
                }
            }
        }

        //Console.WriteLine(CanJump(new int[] { 3, 2, 1, 0, 4 }));
        //Console.WriteLine(CanJump(new int[] { 2, 3, 1, 1, 4 }));
        //Console.WriteLine(CanJump(new int[] { 1, 3, 2 }));
        //Console.WriteLine(CanJump(new int[] { 1, 1, 0, 1 }));
        //Console.WriteLine(CanJump(new int[] { 1, 1, 1, 0 }));
        //Console.WriteLine(CanJump(new int[] { 2, 0, 0 }));
        //Console.WriteLine(CanJump(new int[] { 5, 4, 0, 2, 0, 1, 0, 1, 0 }));
    }
}
