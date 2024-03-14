using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class JumpGame
    {
        static bool CanJump(int[] nums)
        {
            if (nums.Length == 1 || nums[0] >= nums.Length - 1)
            {
                return true;
            }
            if (nums[0] == 0)
            {
                return false;
            }
            int countOfZeros = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1 || nums[i] > nums.Length - 1)
                {
                    return true;
                }
                //second condition and internal FOR below in the best way should be combined. First condition only a case of a second
                if (nums[i] == 0 && nums[i - 1] == 1)
                {
                    //*******************************
                    bool isBiggerIndexExist = false;
                    for (int k = i - 1; k >= 0; k--)
                    {
                        //if (nums[k] == 0)
                        //{
                        //    break;
                        //}
                        if (k + nums[k] > i)
                        {
                            i = k + nums[k];
                            isBiggerIndexExist = true;
                        }
                    }
                    if (!isBiggerIndexExist)
                    {
                        return false;
                    }
                    //********************************
                }
                if (nums[i] == 0)
                {
                    int j;
                    for (j = i; j < nums.Length; j++)
                    {
                        if (nums[j] == 0)
                        {
                            countOfZeros++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //i-1 - return to previous non zero value, since 'i' index having zero as value
                    if (nums[i - 1] <= countOfZeros)
                    {
                        //*******************************
                        bool isBiggerIndexExist = false;
                        for (int k = i - 1; k >= 0; k--)
                        {
                            //since calculation with backward direction, we moving back to first rezo value
                            //if (nums[k] == 0)
                            //{
                            //    break;
                            //}
                            if (k + nums[k] > i - 1 + countOfZeros && nums[k + 1] != 0 || k + nums[k] == nums.Length - 1)
                            {
                                i = k + nums[k];
                                isBiggerIndexExist = true;
                            }
                        }
                        if (!isBiggerIndexExist)
                        {
                            return false;
                        }
                        //********************************
                        //return false;
                    }
                    else
                    {
                        i = j - 1;
                        countOfZeros = 0;
                    }
                }
            }

            return true;
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
