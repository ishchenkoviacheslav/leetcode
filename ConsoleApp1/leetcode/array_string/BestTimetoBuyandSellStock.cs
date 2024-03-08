using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int currentProfit = 0;
            int lowestPrise = int.MaxValue;
            int lowestPriseIndex = int.MaxValue;
            int lowestExcludedIndex = int.MaxValue;
            int previousLowestExcludedIndex = int.MaxValue;

            int highestPrise = -1;
            int highestPriseIndex = int.MaxValue;

            if (prices.Length == 0)
            {
                return 0;
            }
            while (true)
            {
                for (int i = 0; i < prices.Length; i++)
                {
                    if (lowestPrise > prices[i] && i < lowestExcludedIndex)
                    {
                        lowestPrise = prices[i];
                        lowestPriseIndex = i;
                    }
                }

                for (int i = prices.Length - 1; i > -1; i--)
                {
                    if (highestPrise <= prices[i] && i > lowestPriseIndex)
                    {
                        highestPrise = prices[i];
                        highestPriseIndex = i;
                    }
                }

                lowestExcludedIndex = lowestPriseIndex;

                if (highestPrise - lowestPrise > currentProfit)
                {
                    currentProfit = highestPrise - lowestPrise;
                }

                if (previousLowestExcludedIndex == lowestExcludedIndex || lowestExcludedIndex == 0)
                {
                    return currentProfit;
                }

                previousLowestExcludedIndex = lowestExcludedIndex;

                lowestPrise = int.MaxValue;
                lowestPriseIndex = int.MaxValue;

                highestPrise = int.MinValue;
                highestPriseIndex = int.MaxValue;
            }
        }
    }
}
