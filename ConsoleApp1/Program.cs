class Program
{
    static public int RemoveDuplicates(int[] nums)
    {
        var oneOrTwoDuplicates = new List<int>();
        int temp = int.MinValue;
        int countOfAlreadyAdded = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (temp != nums[i])
            {
                countOfAlreadyAdded = 0;
            }
            if (countOfAlreadyAdded < 2)
            {
                temp = nums[i];
                countOfAlreadyAdded++;
                oneOrTwoDuplicates.Add(nums[i]);
            }
        }
        for (int i = 0; i < oneOrTwoDuplicates.Count; i++)
        {
            nums[i] = oneOrTwoDuplicates[i];
        }
        return oneOrTwoDuplicates.Count;
    }

    static void Main()
    {
        int ress = RemoveDuplicates(new int[] { 2, 4, 1 });
        Console.WriteLine(ress);
    }
}