class Program
{
    static public int MaxProfit(int[] prices)
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

    static void Main()
    {
        int ress = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        Console.WriteLine(ress);
    }
}