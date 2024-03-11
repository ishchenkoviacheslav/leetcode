using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class RotateArray
    {
        static public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return;
            }
            if (k > nums.Length)
            {
                while (true)
                {
                    k = k - nums.Length;
                    if (k < nums.Length)
                    {
                        break;
                    }
                }
            }
            int[] clone = new int[nums.Length];

            for (int i = 0; i < k; i++)
            {
                clone[i] = nums[nums.Length - k + i];
            }
            for (int i = 0; i < nums.Length - k; i++)
            {
                clone[k + i] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = clone[i];
            }
        }
    }
}
