﻿class Program
{
    //((())) - BALANCED
    //({[]}) - BALANCED
    //([) - NOT BALANCED
    //([)] - NOT BALANCED
    //([]) - BALANCED
    //)(

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
                if (nums[i-1] <= countOfZeros)
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
                        if (k + nums[k] > i + countOfZeros && nums[k + 1] != 0)
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
                    i = j-1;
                    countOfZeros = 0;
                }
            }
        }

        return true;
    }
    static void Main()
    {
        //Console.WriteLine(CanJump(new int[] { 3, 2, 1, 0, 4 })); //False
        //Console.WriteLine(CanJump(new int[] { 2, 3, 1, 1, 4 })); //True
        //Console.WriteLine(CanJump(new int[] { 1, 3, 2 })); // True
        //Console.WriteLine(CanJump(new int[] { 1, 1, 0, 1 })); // False
        //Console.WriteLine(CanJump(new int[] { 1, 1, 1, 0 })); // True
        //Console.WriteLine(CanJump(new int[] { 2, 0, 0 })); // True
        //Console.WriteLine(CanJump(new int[] { 5, 4, 0, 2, 0, 1, 0, 1, 0 })); //False?
        //Console.WriteLine(CanJump(new int[] { 3, 0, 0, 0 })); //True
        //Console.WriteLine(CanJump(new int[] { 2, 2, 0, 2, 0, 2, 0, 0, 2, 0 })); //False - because 2, 0, 0 is not last of array
        //Console.WriteLine(CanJump(new int[] { 3, 0, 8, 2, 0, 0, 1 })); //True
        Console.WriteLine(CanJump(new int[] { 5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0 })); //True
        //Console.WriteLine(CanJump(new int[] { 8, 2, 4, 4, 4, 9, 5, 2, 5, 8, 8, 0, 8, 6, 9, 1, 1, 6, 3, 5, 1, 2, 6, 6, 0, 4, 8, 6, 0, 3, 2, 8, 7, 6, 5, 1, 7, 0, 3, 4, 8, 3, 5, 9, 0, 4, 0, 1, 0, 5, 9, 2, 0, 7, 0, 2, 1, 0, 8, 2, 5, 1, 2, 3, 9, 7, 4, 7, 0, 0, 1, 8, 5, 6, 7, 5, 1, 9, 9, 3, 5, 0, 7, 5 })); //True
        //Console.WriteLine(CanJump(new int[] { 2, 0, 6, 9, 8, 4, 5, 0, 8, 9, 1, 2, 9, 6, 8, 8, 0, 6, 3, 1, 2, 2, 1, 2, 6, 5, 3, 1, 2, 2, 6, 4, 2, 4, 3, 0, 0, 0, 3, 8, 2, 4, 0, 1, 2, 0, 1, 4, 6, 5, 8, 0, 7, 9, 3, 4, 6, 6, 5, 8, 9, 3, 4, 3, 7, 0, 4, 9, 0, 9, 8, 4, 3, 0, 7, 7, 1, 9, 1, 9, 4, 9, 0, 1, 9, 5, 7, 7, 1, 5, 8, 2, 8, 2, 6, 8, 2, 2, 7, 5, 1, 7, 9, 6 })); //False
    }
}