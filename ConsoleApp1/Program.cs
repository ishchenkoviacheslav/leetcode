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

            if (separatedWords.Length == 1)
            {
                result[i] = separatedWords[0] + new string(' ', maxWidth - commonCountOfSymbols);
            }
            else if (separatedWords.Length == 2)
            {
                result[i] = separatedWords[0] + new string(' ', maxWidth - commonCountOfSymbols) + separatedWords[1];
            }
            else
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