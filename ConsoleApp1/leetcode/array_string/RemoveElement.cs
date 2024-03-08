namespace ConsoleApp1.leetcode.array_string
{
    internal class RemoveElement
    {
        public int RemoveElement_(int[] nums, int val)
        {
            int firstVal = int.MinValue;
            int lastNonVal = int.MinValue;
            int k = int.MinValue;
            if (Array.FindAll(nums, n => n == val).Length == 0)
            {
                return nums.Length;
            }
            do
            {
                firstVal = Array.FindIndex(nums, n => n == val);
                lastNonVal = Array.FindLastIndex(nums, n => n != val);
                if (firstVal != -1 && firstVal < lastNonVal)
                {
                    nums[firstVal] = nums[lastNonVal];
                    nums[lastNonVal] = val;
                }
            } while (firstVal < lastNonVal);

            k = Array.FindIndex(nums, n => n == val);
            if (Array.FindIndex(nums, n => n == val) == -1)
            {
                k = 0;
            }
            if (lastNonVal == 0)
            {
                k = 1;
            }

            return k;
        }
    }
}
