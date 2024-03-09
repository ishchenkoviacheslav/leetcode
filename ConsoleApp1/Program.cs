class Program
{
    static public int MaxProfit(int[] prices)
    {
        int totalProfit = 0;

        int lowestIndex = int.MaxValue;
        int highestIndex = int.MinValue;

        int lowestPrice = int.MaxValue;
        int highestPrice = int.MinValue;

        bool seekingThePeak = false;
        bool seekingTheBottom = true;
        for (int i = 0; i < prices.Length; i++)
        {
            seekingThePeak = true;
            if (prices[i] < lowestPrice && seekingTheBottom)
            {
                lowestPrice = prices[i];
                lowestIndex = i;
                seekingThePeak = false;
            }
            if (prices[i] > highestPrice && seekingThePeak)
            {
                highestPrice = prices[i];
                highestIndex = i;
                seekingTheBottom = false;
                if (prices.Length - 1 == i)
                {
                    return totalProfit += highestPrice - lowestPrice;
                }
            }
            else if (seekingThePeak == true)
            {
                seekingTheBottom = true;
                seekingThePeak = false;// 

                totalProfit += highestPrice - lowestPrice;

                lowestPrice = int.MaxValue;
                highestPrice = int.MinValue;

                lowestIndex = int.MaxValue;
                highestIndex = int.MinValue;
                i--;
            }
        }

        return totalProfit;
    }

    static void Main()
    {
        //int ress = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        //int ress = MaxProfit(new int[] { 1, 2, 3, 4, 5 });
        int ress = MaxProfit(new int[] { 2, 4, 1 });
        Console.WriteLine(ress);
    }
}