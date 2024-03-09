using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class RemoveDuplicatesfromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
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
    }
}
