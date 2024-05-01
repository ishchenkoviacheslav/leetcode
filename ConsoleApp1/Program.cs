class Program
{
    static public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new Dictionary<string,List<int>>();
        HashSet<int> excludingValuesI = new HashSet<int>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (!excludingValuesI.Contains(nums[i]))
            {
                excludingValuesI.Add(nums[i]);
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var orederedValues = new List<int> { nums[i], nums[j], nums[k] }.OrderBy(x => x).Select(x => x.ToString());
                            var orederedKey = string.Join(string.Empty, orederedValues);
                            if (!result.ContainsKey(orederedKey))
                            {
                                result[orederedKey] = new List<int> { nums[i], nums[j], nums[k] };
                            }
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