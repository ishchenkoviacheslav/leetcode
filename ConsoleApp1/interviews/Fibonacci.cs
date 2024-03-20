namespace ConsoleApp1.interviews
{
    internal class Fibonacci
    {
        static public int Fib(int x)
        {
            int i = 1;
            int first = 0;
            int second = 1;
            while (true)
            {
                if (i == x)
                {
                    return first;
                }

                int temp = first + second;
                first = second;
                second = temp;

                i++;
            }
        }
        //Console.WriteLine(Fib(5)); //3
        //Console.WriteLine(Fib(6)); //5
        //Console.WriteLine(Fib(9)); //21
        //Console.WriteLine(Fib(10)); //34
    }
}
