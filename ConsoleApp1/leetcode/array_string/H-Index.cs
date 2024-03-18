using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.array_string
{
    internal class H_Index
    {
        static int HIndex(int[] citations)
        {
            if (citations.Length == 1 && citations[0] > 0)
            {
                return 1;
            }
            if (citations.Length > 0 && !citations.Any(n => n > 0))
            {
                return 0;
            }
            var orderedCitations = citations.OrderByDescending(x => x).Where(n => n > 0).ToList();
            int counter = 0;
            int maxCounter = 0;
            for (int i = 0; i < orderedCitations.Count; i++)
            {
                for (int j = 0; j < orderedCitations.Count; j++)
                {
                    if (orderedCitations[j] >= orderedCitations[i])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    if (counter >= orderedCitations[i])
                    {
                        return maxCounter > orderedCitations[i] ? maxCounter : orderedCitations[i];
                    }
                }
                if (i == orderedCitations.Count - 1)
                {
                    return counter;
                }
                counter = 0;
            }

            return int.MaxValue;
        }
    }
}
