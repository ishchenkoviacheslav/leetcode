class Program
{
    static public int Trap(int[] height)
    {
        int leftPeak = int.MinValue;
        int rightPeak = int.MinValue;
        int notEmptyCurrentSink = 0;
        int leftIndex = 0;
        int rightIndex = 0;
        int waterTotal = 0;
        bool firstPeakInit = true;
        bool bottomOfSinkIsReached = false;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > leftPeak && firstPeakInit)
            {
                leftPeak = height[i];
                leftIndex = i;
                continue;
            }
            else
            {
                firstPeakInit = false;
            }

            //dropping after right peak started
            if (rightPeak > height[i] && bottomOfSinkIsReached)
            {
                //    notEmptyCurrentSink -= height[i];
                //    notEmptyCurrentSink -= rightpeak;

                //    int squareBetween = Math.Min(leftpeak, rightpeak) * (((rightIndex + 1) - (leftIndex + 1)) - 1);
                //    waterTotal += squareBetween - notEmptyCurrentSink;

                //    notEmptyCurrentSink = 0;

                //    leftIndex = rightIndex;
                //    leftpeak = rightpeak;
                //    rightpeak = int.MinValue;
                //    rightIndex = 0;
                //    i--;
            }
            else
            {
                notEmptyCurrentSink += height[i];
                rightPeak = height[i];
                rightIndex = i;
                //raising to the right peak started
                if (rightPeak < height[i])
                {
                    bottomOfSinkIsReached = true;
                }
            }
        }

        return waterTotal;
    }

    static async Task Main()
    {
        Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
    }
}