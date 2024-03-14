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
        int balancerRound = 0;
        int balancerCurve = 0;
        int balancerSquare = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '(' || chars[i] == ')')
            {
                if (chars[i] == '(')
                {
                    balancerRound++;
                }
                if (chars[i] == ')')
                {
                    balancerRound--;
                }
            }
            //***************************************
            if (chars[i] == '{' || chars[i] == '}')
            {
                if (chars[i] == '{')
                {
                    balancerCurve++;
                }
                if (chars[i] == '}')
                {
                    balancerCurve--;
                }
            }
            //***************************************
            if (chars[i] == '[' || chars[i] == ']')
            {
                if (chars[i] == '[')
                {
                    balancerSquare++;
                }
                if (chars[i] == ']')
                {
                    balancerSquare--;
                }
            }

            if (balancerRound < 0 || balancerCurve < 0 || balancerSquare < 0)
            {
                return false;
            }
        }

        return balancerRound == 0 &&balancerCurve == 0 &&balancerSquare == 0;
    }
    static void Main()
    {
        //Console.WriteLine(IsBalanced("((()))")); //T
        //Console.WriteLine(IsBalanced("({[]})")); //T
        //Console.WriteLine(IsBalanced("([)"));//F
        Console.WriteLine(IsBalanced("([)]")); //F
        //Console.WriteLine(IsBalanced("([])")); //T
        //Console.WriteLine(IsBalanced(")(")); //F
    }
}