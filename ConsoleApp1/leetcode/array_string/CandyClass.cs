using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class CandyClass
    {
        public int Candy(int[] ratings)
        {
            if (ratings.Length == 1)
            {
                return 1;
            }
            int totalCandies = 0;
            int currentCandies = 1;
            bool needToUseExtraAdd = false;
            int extraAdd = 0;
            for (int i = 0; i < ratings.Length; i++)
            {
                if (i == 0)
                {
                    if (ratings[i] > ratings[i + 1])
                    {
                        currentCandies++;
                    }
                    totalCandies += currentCandies;
                    continue;
                }
                if (i == ratings.Length - 1)
                {
                    if (ratings[i] <= ratings[i - 1] && currentCandies > 1)
                    {
                        currentCandies = 1;
                    }
                    else if (ratings[i] > ratings[i - 1])
                    {
                        currentCandies++;
                    }
                    totalCandies += currentCandies;

                    continue;
                }

                //////////////////////////////////////////////////////////////////////////////
                //123 ++
                //321 =2?
                //222 =1
                //223 =1
                //221 =2?
                //211 =1
                //122 ++
                //121 ++
                //212 =1
                if (ratings[i - 1] < ratings[i] && ratings[i] < ratings[i + 1])
                {
                    currentCandies++;
                }
                else if (ratings[i - 1] > ratings[i] && ratings[i] > ratings[i + 1])
                {
                    int goingStrightDownCounter = 1;
                    for (int j = i; j < ratings.Length - 1; j++)
                    {
                        if (ratings[j] > ratings[j + 1])
                        {
                            goingStrightDownCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //next after top before down...
                    if (currentCandies < goingStrightDownCounter)
                    {
                        extraAdd = goingStrightDownCounter - currentCandies + 1;
                        needToUseExtraAdd = true;
                        currentCandies = goingStrightDownCounter;
                    }
                    else if (currentCandies == goingStrightDownCounter)
                    {
                        extraAdd = 1;
                        needToUseExtraAdd = true;
                    }
                    else
                    {
                        if (currentCandies - goingStrightDownCounter > 0)
                        {
                            currentCandies = currentCandies - (currentCandies - goingStrightDownCounter);
                        }
                        else
                        {
                            currentCandies--;
                        }
                    }
                }
                else if (ratings[i - 1] == ratings[i] && ratings[i] == ratings[i + 1])
                {
                    currentCandies = 1;
                }
                else if (ratings[i - 1] == ratings[i] && ratings[i] < ratings[i + 1])
                {
                    currentCandies = 1;
                }
                else if (ratings[i - 1] == ratings[i] && ratings[i] > ratings[i + 1])
                {
                    int goingStrightDownCounter = 1;
                    for (int j = i; j < ratings.Length - 1; j++)
                    {
                        if (ratings[j] > ratings[j + 1])
                        {
                            goingStrightDownCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currentCandies < goingStrightDownCounter)
                    {
                        currentCandies = goingStrightDownCounter;
                    }
                    else if (currentCandies == goingStrightDownCounter)
                    {
                        //nothing doing
                    }
                    else
                    {
                        if (currentCandies - goingStrightDownCounter > 0)
                        {
                            currentCandies = currentCandies - (currentCandies - goingStrightDownCounter);
                        }
                        else
                        {
                            currentCandies--;
                        }
                    }
                }
                else if (ratings[i - 1] > ratings[i] && ratings[i] == ratings[i + 1])
                {
                    currentCandies = 1;
                }
                else if (ratings[i - 1] < ratings[i] && ratings[i] == ratings[i + 1])
                {
                    currentCandies++;
                }
                else if (ratings[i - 1] < ratings[i] && ratings[i] > ratings[i + 1])
                {
                    currentCandies++;
                }
                else if (ratings[i - 1] > ratings[i] && ratings[i] < ratings[i + 1])
                {
                    currentCandies = 1;
                }
                else
                {
                    throw new Exception("uncovered case");
                }
                //////////////////////////////////////////////////////////////////////////////
                if (needToUseExtraAdd)
                {
                    needToUseExtraAdd = false;
                    totalCandies += extraAdd;
                    extraAdd = 0;
                }
                totalCandies += currentCandies;
            }

            return totalCandies;
        }
    }
}
