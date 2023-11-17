using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
             TestTask();
            Console.ReadLine();
        }
        public static async void TestTask()
        {
            var watch = new Stopwatch();
            watch.Start();
            var task1 = Task1();
            await task1;
            var task2 = Task2();
            var task3 = Task3();

            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Exexcution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static async Task Task1()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task1 Async");
            });
        }
        public static async Task Task2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Task2 Async");
            });
        }
        public static async Task Task3()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2500);
                Console.WriteLine("Task3 Async");
            });
        }
    }
}
