namespace ConsoleApp1.leetcode.array_string
{
    internal class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (nums1[i] == 0)
                {
                    nums1[i] = int.MaxValue;
                }
                else
                {
                    break;
                }
            }

            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                if (nums2[i] == 0)
                {
                    nums2[i] = int.MaxValue;
                }
                else
                {
                    break;
                }
            }

            var res = nums1.Concat(nums2).Where(i => i != int.MaxValue).OrderBy(i => i).ToList();

            if (m + n > res.Count())
            {
                int counter = res.Count();
                for (int i = 0; i < counter; i++)
                {
                    res.Add(0);
                }
            }
            var arr = res.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                nums1[i] = arr[i];
            }
        }
    }
}

