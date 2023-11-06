using System;
using System.Collections.Generic;
using System.Linq;

public class FindFirstAndSecondMaxNumbers
{
    public static void Main(String[] args)
    {
        int[] NumArr = { 20, 19, 21 };
        Array.Sort(NumArr);

        int maxNum = NumArr[0];
        int secondMaxNum = 0;

        //Find First Maximun Number
        for (int i = 0; i < NumArr.Length; i++)
        {
            if (maxNum < NumArr[i])
            {
                maxNum = NumArr[i];
            }
        }
        Console.WriteLine("First Maximum Number:" + maxNum);

        //find second maximun number
        if (NumArr.Length == 1)
        {
            Console.WriteLine("Cannot Find Second Maximun Number");
            return;
        }
        for (int j = 0; j < NumArr.Length; j++)
        {
            if (maxNum != NumArr[j])
            {
                secondMaxNum = NumArr[j];
            }
        }
        Console.WriteLine("Second Maximum Number: " + secondMaxNum);
    }
}