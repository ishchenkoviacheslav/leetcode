using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interviews
{
    internal class TaskAsyncAwaitWhenAll
    {
        async Task MyMainThree()
        {
            await Console.Out.WriteLineAsync("1");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var t1 = SquareAsync(5);
            var t2 = SquareAsync(6);

            int n1 = await t1;
            int n2 = await t2;
            Console.WriteLine($"n1={n1}  n2={n2}"); // n1=25  n2=36

            async Task<int> SquareAsync(int n)
            {
                await Task.Delay(3000);
                return n * n;
            }

            stopwatch.Stop();
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} миллисекунд");
        }

        async Task MyMainTwo()
        {
            Task task1 = new Task(() =>
            {
                Console.WriteLine("Task Starts");
                Thread.Sleep(3000);
                Console.WriteLine("Task Ends");
            });
            task1.Start();

            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

            Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));
            task2.Wait();
            task3.Wait();
            //blocking current thread, but only in place when Wait method called
            //task1.Wait();
            Thread.Sleep(4000);

        }
        async Task MyMain()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Task<int> task1 = Task1Async();
            Task<string> task2 = Task2Async();
            Task<bool> task3 = Task3Async();

            //Seems like there is no any difference with or without WhenAll method - the same time in stopwatch
            //await Task.WhenAll(task1, task2, task3);

            int result1 = await task1;
            string result2 = await task2;
            bool result3 = await task3;

            stopwatch.Stop();
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} миллисекунд");

            Console.WriteLine($"Результат task1: {result1}");
            Console.WriteLine($"Результат task2: {result2}");
            Console.WriteLine($"Результат task3: {result3}");
        }

        async Task<int> Task1Async()
        {
            await Task.Delay(2000);
            return 42;
        }

        async Task<string> Task2Async()
        {
            await Task.Delay(1000);
            return "Hello";
        }

        async Task<bool> Task3Async()
        {
            await Task.Delay(1500);
            return true;
        }
    }
}
