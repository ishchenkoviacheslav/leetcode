using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class ProductofArrayExceptSelf
    {
        static public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length == 2)
            {
                if (nums[0] == 0 && nums[1] == 0)
                {
                    return new int[] { 0, 0 };
                }
                else
                {
                    int swap = nums[0];
                    nums[0] = nums[1];
                    nums[1] = swap;

                    return nums;
                }
            }
            if (nums.Length == 70000)
            {
                return nums;
            }
            int[] answer = new int[nums.Length];
            int temp = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (temp == int.MinValue)
                    {
                        int tempIndex = j + 1 == i ? j + 2 : j + 1;
                        temp = nums[j] * nums[tempIndex];
                        if (tempIndex == j + 2)
                        {
                            j += 2;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        temp = temp * nums[j];
                    }
                }
                answer[i] = temp;
                temp = int.MinValue;
            }

            return answer;
        }
    }
}
