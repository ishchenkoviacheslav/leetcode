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
            else if (i == result.Count - 1)
            {
                result[i] = string.Empty;
                for (int j = 0; j < separatedWords.Length - 1; j++)
                {
                    result[i] += separatedWords[j] + " ";
                }
                commonCountOfSymbols += separatedWords.Length > 1 ? separatedWords.Length - 1 : 0;
                result[i] += separatedWords[separatedWords.Length - 1] + new string(' ', maxWidth - commonCountOfSymbols);
            }
            else if (separatedWords.Length == 2 && i != result.Count - 1)
            {
                result[i] = separatedWords[0] + new string(' ', maxWidth - commonCountOfSymbols) + separatedWords[1];
            }
            else
            {
                bool stillLooping = true;
                while (stillLooping)
                {
                    for (int j = 0; j < separatedWords.Length - 1; j++)
                    {
                        separatedWords[j] += " ";
                        if (separatedWords.Sum(s => s.Length) == maxWidth)
                        {
                            stillLooping = false;
                            break;
                        }
                    }
                }

                result[i] = string.Empty;
                for (int k = 0; k < separatedWords.Length; k++)
                {
                    result[i] += separatedWords[k];
                }
            }
        }

        return result.Select(kvp => kvp.Value).ToList();
    }
    static async Task Main()
    {
        //var result = FullJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);
        //var result = FullJustify(new string[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16);
        var result = FullJustify(new string[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16);
        foreach (var item in result)
        {
            await Console.Out.WriteLineAsync(item);
        }
    }
}