using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interviews
{
    internal class TaskAwaitWhenAll
    {
        static async Task My()//Main
        {
            await Task.Run(async () =>
            {
                await Task.Delay(10000);
                await Console.Out.WriteLineAsync("10 000");
            });

            await Task.Run(async () =>
            {
                await Task.Delay(5000);
                await Console.Out.WriteLineAsync("5 000");
            });

            Console.WriteLine("end one");
            ///////////////////////////////////////////////////////////
            Task t1 = Task.Run(async () =>
            {
                await Task.Delay(10000);
                await Console.Out.WriteLineAsync("10 000");
            });

            Task t2 = Task.Run(async () =>
            {
                await Task.Delay(5000);
                await Console.Out.WriteLineAsync("5 000");
            });

            Console.WriteLine("end two");

            await Task.WhenAll(t1, t2);
        }
    }
}
