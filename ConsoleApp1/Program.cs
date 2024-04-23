class Program
{
    static public int Candy(int[] ratings)
    {
        int totalCandies = 0;
        int currentCandies = 1;
        bool needToUseExtraAdd = false;
        int extraAdd = 0;
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
            //321 =2?
            //222 =1
            //223 =1
            //221 =2?
            //211 =1
            //122 ++
            //121 ++
            //212 =1
            if (ratings[i - 1] < ratings[i] && ratings[i] < ratings[i + 1])
            {
                currentCandies++;
            }
            else if (ratings[i - 1] > ratings[i] && ratings[i] > ratings[i + 1])
            {
                int exactCaseCandies = 1;
                for (int j = i; j < ratings.Length - 1; j++)
                {
                    if (ratings[j] > ratings[j + 1])
                    {
                        exactCaseCandies++;
                    }
                    else
                    {
                        break;
                    }
                }
                 //next after top before down...
                if (currentCandies < exactCaseCandies)
                {
                    extraAdd = exactCaseCandies - currentCandies + 1;
                    needToUseExtraAdd = true;
                    currentCandies = exactCaseCandies;
                }
                else
                {
                    currentCandies--;
                }
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
                int exactCaseCandies = 1;
                for (int j = i; j < ratings.Length - 1; j++)
                {
                    if(ratings[j] > ratings[j + 1])
                    {
                        exactCaseCandies++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCandies < exactCaseCandies)
                {
                    currentCandies = exactCaseCandies;
                }
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
            //////////////////////////////////////////////////////////////////////////////
            if (needToUseExtraAdd)
            {
                needToUseExtraAdd = false;
                totalCandies += extraAdd;
            }
            totalCandies += currentCandies;
        }

        return totalCandies;
    }

    static void Main()
    {
        //Console.WriteLine(Candy(new[] { 1, 0, 2 }));    //5
        //Console.WriteLine(Candy(new[] { 1, 2, 2 }));    //4
        //Console.WriteLine(Candy(new[] { 1, 2, 87, 87, 87, 2, 1 }));    //13
        ////                              1  2  3   1   3   2  1 - should be
        ////                              1  2  3   1   2   2  1 - actual have
        //Console.WriteLine(Candy(new[] { 29, 51, 87, 87, 72, 12 }));    //12
        //                              1   2   3    3   2   1 - should be
        //                              1     - actual have
        //Console.WriteLine(Candy(new[] { 1, 6, 10, 8, 7, 3, 2 }));    //18
        //                              1  2   5  4  3  2  1 - should be
        //                              1  2   3  2  1  0  0 - actual have
        Console.WriteLine(Candy(new[] { 0, 1, 2, 3, 2, 1 }));    //13

    }
}