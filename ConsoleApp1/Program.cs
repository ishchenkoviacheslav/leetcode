class Program
{
    static public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new Dictionary<int, string>();

        for (int i = 0, j = 0; i < words.Length; i++)
        {
            result.Add(j, words[i]);
        }

        return result;
    }
    static async Task Main()
    {
        var result = FullJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);
        foreach (var item in result)
        {
            await Console.Out.WriteLineAsync(item);
        }
    }
}