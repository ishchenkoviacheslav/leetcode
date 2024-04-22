class Program
{
    static public int Candy(int[] ratings)
    {
        int totalCandies = 0;
        int currentCandies = 1;
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
                    currentCandies--;
                }
                else if (ratings[i] > ratings[i - 1])
                {
                    currentCandies++;
                }
                totalCandies += currentCandies;

                continue;
            }

            if (ratings[i] > ratings[i + 1] || ratings[i] > ratings[i - 1])
            {
                currentCandies++;
            }
            else if (ratings[i] <= ratings[i + 1] && currentCandies > 1)
            {
                currentCandies--;
            }
            totalCandies += currentCandies;
        }

        return totalCandies;
    }
    static void Main()
    {
        Console.WriteLine(Candy(new []{ 1,0,2}));       //5
        Console.WriteLine(Candy(new []{ 1, 2, 2 }));    //4
    }
}