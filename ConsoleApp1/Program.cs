class Program
{
    static public int Trap(int[] height)
    {
        //two rules how to deretmine if it's peak.
        //1 - if there is any peak which is heighest than first (or equals?)
        //2 - if there is only peak which is not so high as first, but it's highest between others
        //to be sure with this case, it's need to be checked to the end of the array
        int totalNotEmptyArea = 0, totalArea = 0;
        int peakOneIndex = -1, peakTwoIndex = -1, peakOneValue = 0, peakTwoValue = 0;
        bool firstPeakLogic = true, secondDescendingPeak = false, secondPeakFinished = false;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] >= peakOneValue && firstPeakLogic)
            {
                peakOneValue = height[i];
                peakOneIndex = i;
            }
            firstPeakLogic = false;
            //looking for a raising peak
            if(height[i] >= peakOneValue && secondPeakFinished == false )
            {
                peakTwoValue = height[i];
                peakTwoIndex = i;
                secondPeakFinished = true;
                continue;
            }
            else if (i == height.Length - 1 && secondDescendingPeak == false && secondPeakFinished == false)
            {
                secondDescendingPeak = true;
                i = peakOneIndex;
                continue;
            }

            //loking for decreasing peak but the heighest
            //>= ???
            if (height[i] > peakTwoValue && secondDescendingPeak)
            {
                peakTwoValue = height[i];
                peakTwoIndex = i;
            } 
            else if (i == height.Length - 1 && secondDescendingPeak)
            {
                secondPeakFinished = true;
            }

            if (firstPeakLogic == false && secondPeakFinished)
            {
                totalArea += Math.Min(peakOneValue, peakTwoValue) * (peakTwoIndex - peakOneIndex - 1);
                for (int j = peakOneIndex + 1; j < peakTwoIndex; j++)
                {
                    totalNotEmptyArea += height[j];
                }

                bool canToBreak = false;
                int temp = int.MaxValue;
                for (int j = peakTwoIndex + 1; j < height.Length; j++)
                {
                    if (height[j] < peakTwoValue && height[j] < temp)
                    {
                        canToBreak = true;
                    }
                    else
                    {
                        canToBreak = false;
                        break;
                    }
                    temp = height[j];
                }
                if (canToBreak)
                {
                    break;
                }
                //firstPeakLogic = true;
                i = peakTwoIndex;
                peakOneIndex = peakTwoIndex;
                peakOneValue = peakTwoValue;
                peakTwoIndex = -1;
                peakTwoValue = 0;
                secondDescendingPeak = false;
                secondPeakFinished = false;
            }
        }

        return totalArea - totalNotEmptyArea;
    }

    static async Task Main()
    {
        Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
    }
}