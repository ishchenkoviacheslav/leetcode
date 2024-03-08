namespace ConsoleApp1.leetcode.array_string
{
    internal class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int[] uniqeValues = new int[nums.Length];
            Array.Fill(uniqeValues, int.MinValue);
            int i = 0;
            int j = 0;
            while (true)
            {
                if (i == 0)
                {
                    uniqeValues[i] = nums[i];
                    i++;
                    j++;
                    k++;
                    if (i == nums.Length)
                    {
                        break;
                    }
                    continue;
                }

                if (nums[i - 1] < nums[i])
                {
                    uniqeValues[j] = nums[i];
                    j++;
                    k++;
                }

                i++;
                if (i == nums.Length)
                {
                    break;
                }
            }
            for (int n = 0; n < nums.Length; n++)
            {
                nums[n] = uniqeValues[n];
            }

            return k;
        }
    }
}
