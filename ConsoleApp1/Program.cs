class Program
{
    static public int Trap(int[] height)
    {
        int leftPeek = int.MinValue;
        int rightPeek = int.MinValue;
        int notEmptyCurrentPeeks = 0;
        int leftIndex = 0;
        int rightIndex = 0;
        int waterTotal = 0;
        bool firstPeekInit = true;

        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > leftPeek && firstPeekInit)
            {
                leftPeek = height[i];
                leftIndex = i;
                continue;
            }
            else
            {
                firstPeekInit = false;
            }
            notEmptyCurrentPeeks += height[i];
            //if equals?
            if (height[i] > rightPeek)
            {
                rightPeek = height[i];
                rightIndex = i;
            }
            else
            {
                notEmptyCurrentPeeks -= height[i];
                notEmptyCurrentPeeks -= rightPeek;

                int squareBetween = Math.Min(leftPeek, rightPeek) * (((rightIndex + 1) - (leftIndex + 1)) - 1);
                waterTotal += squareBetween - notEmptyCurrentPeeks;

                notEmptyCurrentPeeks = 0;

                leftIndex = rightIndex;
                leftPeek = rightPeek;
                rightPeek = int.MinValue;
                rightIndex = 0;
            }
        }

        return waterTotal;
    }

    static async Task Main()
    {
        Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
    }
}