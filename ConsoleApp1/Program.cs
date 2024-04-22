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
            //321 -- || =2?
            //222 =1
            //223 =1
            //221 -- || =2?
            //211 =1
            //122 ++
            //121 ++
            //212 =1
            if (ratings[i - 1] < ratings[i] && ratings[i] > ratings[i + 1])
            {
                currentCandies++;
            }
            else if (ratings[i - 1] > ratings[i] && ratings[i] < ratings[i + 1])
            {
                currentCandies--;//=2?
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
                currentCandies--;//=2?
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
            //if (ratings[i] > ratings[i + 1] || ratings[i] > ratings[i - 1])
            //{
            //    if (ratings[i] > ratings[i + 1])
            //    {
            //        currentCandies++;
            //    }
            //    if (ratings[i] == ratings[i - 1])
            //    {

            //    }
            //    if (ratings[i] <= ratings[i - 1])
            //    {
            //    }
            //}
            //else if (ratings[i] <= ratings[i + 1] && currentCandies > 1)
            //{
            //    currentCandies = 1;
            //}
            //////////////////////////////////////////////////////////////////////////////
            totalCandies += currentCandies;
        }

        return totalCandies;
    }
    static void Main()
    {
        Console.WriteLine(Candy(new[] { 1, 0, 2 }));       //5
        //Console.WriteLine(Candy(new[] { 1, 2, 2 }));    //4
        //Console.WriteLine(Candy(new []{ 1, 2, 87, 87, 87, 2, 1 }));    //13
        //Console.WriteLine(Candy(new []{ 29, 51, 87, 87, 72, 12 }));    //12
        //                              1   2   3   
    }
}