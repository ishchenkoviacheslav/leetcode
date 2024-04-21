using System.Text;

class Program
{
    static public string Convert(string s, int numRows)
    {
        StringBuilder[] rows = new StringBuilder[numRows];
        for (int i = 0; i < rows.Length; i++)
        {
            rows[i] = new StringBuilder();
        }
        var asChars = s.ToCharArray();

        for (int i = 0; i < asChars.Length; i++)
        {
            rows[j].Append(asChars[i]);
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < rows.Length; i++)
        {
            result.Append(rows[i]);
        }

        return result.ToString();
    }
    static void Main()
    {
        Console.WriteLine(Convert("PAYPALISHIRING", 3));
        Console.WriteLine(Convert("PAYPALISHIRING", 4));
    }
}