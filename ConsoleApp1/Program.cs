class Program
{
    static public int Trap(int[] height)
    {
        int totalArea = 0;
        int totalNotEmpty = 0;
        Dictionary<int, int> indexHeightPair = new Dictionary<int, int>();
        for (int i = 0; i < height.Length; i++)
        {
            indexHeightPair.Add(i, height[i]);
        }

        var sortedIndexHeightPair = indexHeightPair.OrderByDescending(kvp => kvp.Value).ToDictionary(x => x.Key, x => x.Value);

        int firstIndex = int.MinValue;
        int firstValue = int.MinValue;
        int secondIndex = int.MinValue;
        int secondValue = int.MinValue;
        while (sortedIndexHeightPair.Count > 0)
        {
            var kvp = sortedIndexHeightPair.First();
            firstIndex = kvp.Key;
            firstValue = kvp.Value;
            sortedIndexHeightPair.Remove(firstIndex);
            kvp = sortedIndexHeightPair.First();
            secondIndex = kvp.Key;
            secondValue = kvp.Value;
            sortedIndexHeightPair.Remove(secondIndex);
            totalArea += Math.Min(firstValue, secondValue) * (Math.Max(firstIndex, secondIndex) - Math.Min(firstIndex, secondIndex) - 1);
            for (int i = Math.Min(firstIndex, secondIndex)+1; i < Math.Max(firstIndex, secondIndex); i++)
            {
                totalNotEmpty += sortedIndexHeightPair[i];
                sortedIndexHeightPair.Remove(i);
            }
        }

        return totalArea - totalNotEmpty;
    }

    static async Task Main()
    {
        Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
    }
}