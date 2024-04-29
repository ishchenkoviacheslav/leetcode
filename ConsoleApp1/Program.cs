class Program
{
    static public int Trap(int[] height)
    {
        //two rules how to deretmine if it's peak.
        //1 - if there is any peak which is heighest than first (or equals)
        //just use this logic height[i] >= peakOneValue
        //2 - if there is only peak which is not so high as first, but it's highest than latest
        //to be sure with this case, it's need to be checked to the end of the array
        //and if nothing found, than use the highest peak is found.
        //
        int totalNotEmptyArea = 0, totalArea = 0;
        int peakOneIndex = -1, peakTwoIndex = -1, peakOneValue = 0, peakTwoValue = 0;
        int heigherDescendingPeakValue = 0;
        int heigherDescendingPeakIndex = -1;
        bool firstPeakLogic = true, secondDescendingPeak = false;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] >= peakOneValue && firstPeakLogic)
            {
                peakOneValue = height[i];
                peakOneIndex = i;
            }
            firstPeakLogic = false;
            //looking for a raising peak
            if(height[i] >= peakOneValue && secondDescendingPeak == false)
            {
                peakTwoValue = height[i];
                peakTwoIndex = i;
            }
            else if (i == height.Length - 1 && secondDescendingPeak == false)
            {
                secondDescendingPeak = true;
                i = peakOneIndex;
            }

            if (height[i] > heigherDescendingPeakValue && secondDescendingPeak)
            {
                heigherDescendingPeakValue = height[i];
                heigherDescendingPeakIndex = i;
            } 
            else if (i == height.Length - 1 && secondDescendingPeak)
            {
                peakTwoValue = heigherDescendingPeakValue;
                peakTwoIndex = heigherDescendingPeakIndex;
            }


            if (firstPeakLogic == false && )
            {

            }
        }

        return totalArea - totalNotEmptyArea;
    }

    static async Task Main()
    {
        Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
    }
}