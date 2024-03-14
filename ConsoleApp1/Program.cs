class Program
{
    //((())) - BALANCED
    //({[]}) - BALANCED
    //([) - NOT BALANCED
    //([)] - NOT BALANCED
    //([]) - BALANCED
    //)(

    static bool IsBalanced(string s)
    {
        var chars = s.ToCharArray();
        int balancer = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '(')
            {
                balancer++;
            }
            else if (chars[i] == ')')
            {
                balancer--;
            }

            return balancer < 0;
        }

        return balancer == 0;
    }
    static void Main()
    {
        Console.WriteLine(IsBalanced("((()))"));
        Console.WriteLine(IsBalanced(")("));
    }
}