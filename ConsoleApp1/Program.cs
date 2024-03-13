class Program
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
                bool isBiggerIndexExist = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (nums[k] == 0)
                    {
                        break;
                    }
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
            }
            if (nums[i] == 0)
            {
                int j;
                for (j = i; j <= nums.Length - 1; j++)
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
                if (nums[i-1] <= countOfZeros)
                {
                    return false;
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

    }
}