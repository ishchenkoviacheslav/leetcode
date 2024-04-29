class Program
{
    static public int Trap(int[] height)
    {
        //two rules how to deretmine if it's peak.
        //1 - if there is any peak which is heighest than first (or equals)
        //just use this logic height[i] >= peekOneValue
        //2 - if there is only peak which is not so high as first, but it's highest than latest
        //to be sure with this case, it's need to be checked to the end of the array
        //and if nothing found, than use the highest peak is found.
        //
        int totalNotEmptyArea = 0, totalArea = 0;
        int peekOneIndex = 0, peekTwoIndex = 0, peekOneValue = 0, peekTwoValue = 0;
        bool firstPeakLogic = true;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] >= peekOneValue && firstPeakLogic)
            {
                peekOneValue = height[i];
                peekOneIndex = i;
            }
            else
            {
                firstPeakLogic = false;

            }
        }

        return totalArea - totalNotEmptyArea;
    }

    static async Task Main()
    {
        Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
    }
}