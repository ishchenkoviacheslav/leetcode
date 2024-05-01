using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.Two_Pointers
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int result = 0;
            int left = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                if (height[i] < left)
                {
                    continue;
                }
                else
                {
                    left = height[i];
                }
                for (int j = i + 1; j < height.Length; j++)
                {
                    if (Math.Min(height[i], height[j]) * (j - i) > result)
                    {
                        result = Math.Min(height[i], height[j]) * (j - i);
                    }
                }
            }

            return result;
        }
    }
}
