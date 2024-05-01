class Program
{
    static public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new Dictionary<string, List<int>>();

        var onlyUniqe = nums.Distinct().ToHashSet();
        HashSet<int> excludingValuesI = new HashSet<int>();
        int temp = 0, lookingNumber = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!excludingValuesI.Contains(nums[i]))
            {
                excludingValuesI.Add(nums[i]);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    temp = nums[i] + nums[j];
                    if (temp == 0)
                    {
                        lookingNumber = 0;
                    }
                    else if (temp > 0)
                    {
                        lookingNumber = temp * -1;
                    }
                    else if (temp < 0)
                    {
                        lookingNumber = Math.Abs(temp);
                    }
                    if (onlyUniqe.Contains(lookingNumber))
                    {
                        var orederedValues = new List<int> { nums[i], nums[j], lookingNumber }.OrderBy(x => x).Select(x => x.ToString());
                        var orederedKey = string.Join(string.Empty, orederedValues);
                        if (!result.ContainsKey(orederedKey))
                        {
                            result[orederedKey] = new List<int> { nums[i], nums[j], lookingNumber };
                        }
                    }
                }
            }
        }

        return result.Values.Cast<IList<int>>().ToList();
    }
    static async Task Main()
    {
        foreach (var items in ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }))
        {
            foreach (var item in items)
            {
                await Console.Out.WriteAsync(item.ToString() + " ");
            }
            await Console.Out.WriteLineAsync();
        }
    }
}