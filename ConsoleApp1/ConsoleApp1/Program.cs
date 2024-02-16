using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string CurrentDayValue(string S, int K)
        {
            // Implement your solution here
            if (K < 0)
            {
                return "Cannot determine for negative numbers";
            }
            string[] daysArr = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            //finding the index value of the day
            int currDayValue = Array.IndexOf(daysArr, S);
            //Console.WriteLine(currDayValue);
            //Mod to determine the new day value by adding the integer to the current day value
            int newDayValue = ((currDayValue + K) % 7);
            //Get the new day string
            string newDayString = daysArr[newDayValue];
            //Console.WriteLine(newDayString);
            return newDayString;
        }
        public static string[] FiboSolution(int X)
        {
            // write your code in C#
            string[] fibArray = new string[X];
            for (int i = 0; i < fibArray.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibArray[i] = i.ToString();
                }

                else
                {
                    fibArray[i] = (double.Parse(fibArray[i - 1])
                                + double.Parse(fibArray[i - 2])).ToString();
                }
            }
            return fibArray;
        }
        static void Main(string[] args)
        {
            //Determine the currentday based on the integer value
            //and day of the week provided
            string currDayValue = CurrentDayValue("Sun", 10);
            Console.WriteLine(currDayValue);

            // Generate Fibonacci Series
            string[] fiboArray = FiboSolution(100);
            foreach(var fibonacciList in fiboArray)
            {
                Console.WriteLine(fibonacciList);
            }
            
        }
    }
   
}
