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
            bool endApplication = false;
            Console.WriteLine("Calculator");
            
            while (!endApplication)
            {
                Console.WriteLine("Enter First Number: ");
                float num1 = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Second Number: ");
                float num2 = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("1. Press 'a' for Add Numbers");
                Console.WriteLine("2. Press 's' for Subtract Numbers");
                Console.WriteLine("3. Press 'm' for Multiply Numbers");
                Console.WriteLine("4. Press 'd' for divide Numbers");
                Console.Write("Enter Your Option? ");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Addition Result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"Subtraction Result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Multiplication Result: {num1} * {num2} =" + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"Division Result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Not a valid input...");
                        break;

                }
                Console.WriteLine("Do you want end the calculator? (Enter 'Yes' or 'No') ");
                string endApp = Console.ReadLine();
                if (endApp == "No")
                {
                    endApplication = false;
                }
                else if(endApp == "Yes")
                {
                    endApplication = true;
                }
                else
                {
                    Console.WriteLine("Enter Valid value 'Yes' or 'No'....");
                    endApplication = false;
                }
            } 

        }
        
    }
}
