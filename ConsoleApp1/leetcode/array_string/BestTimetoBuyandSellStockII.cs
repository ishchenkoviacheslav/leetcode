using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            int totalProfit = 0;

            int lowestIndex = int.MinValue;
            int highestIndex = int.MinValue;

            int lowestPrice = int.MaxValue;
            int highestPrice = int.MinValue;

            bool seekingThePeak = false;
            for (int i = 0; i < prices.Length; i++)
            {
                seekingThePeak = true;
                if (prices[i] < lowestPrice)
                {
                    lowestPrice = prices[i];
                    lowestIndex = i;
                    seekingThePeak = false;
                }
                if (seekingThePeak && prices[i] > highestPrice)
                {
                    highestPrice = prices[i];
                    highestIndex = i;
                }
            }

            return totalProfit;
        }
    }
}
