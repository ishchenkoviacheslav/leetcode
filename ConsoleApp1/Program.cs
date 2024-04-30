class Program
{
    static public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new Dictionary<int, string>();
        for (int i = 0, j = 0; i < words.Length; i++)
        {
            var lengthOfStoredWord = result.ContainsKey(j) ? result[j].Length + 1 : 0;

            if (lengthOfStoredWord + words[i].Length < maxWidth)
            {
                if (result.ContainsKey(j))
                {
                    result[j] += " " + words[i];
                }
                else
                {
                    result.Add(j, words[i]);
                }
            }
            else
            {
                j++;
                i--;
            }
        }

        for (int i = 0; i < result.Count; i++)
        {
            var separatedWords = result[i].Split(" ", StringSplitOptions.TrimEntries);
            var commonCountOfSymbols = separatedWords.Sum(s => s.Length);
            var temp = string.Empty;
            for (int j = 0; j < separated.Length; j++)
            {

            }
        }

        return result.Select(kvp => kvp.Value).ToList();
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