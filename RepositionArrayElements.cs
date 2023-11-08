using System;
using System.Collections.Generic;
using System.Linq;

class RepositionArrayElements
{

    private static void PositionToShift(int[] arr, int arrLen, int oldPos, int newPos)
    {
        //Define temporary array to store the element in correct order.
        int[] tempArr = new int[arrLen];

        //Array Position initialization for temproaray Array
        int tempArrIncrement = 0;

        // Reposition the elements in array
        for (int i = 0; i < arrLen; i++)
        {
            if (i == oldPos - 1)
            {
                tempArr[i] = arr[newPos - 1];
            }
            else if (i == newPos - 1)
            {
                tempArr[i] = arr[oldPos - 1];
            }
            else
            {
                tempArr[tempArrIncrement] = arr[i];
            }
            tempArrIncrement++;
        }
        Console.WriteLine("Position Shift:");
        Array.ForEach(tempArr, i => Console.WriteLine(i));
    }
    public static void Main(String[] args)
    {
        int[] arr = { 1, 2, 3, 7, 5, 20 };
        int n = arr.Length; //length of array
        int oldPos = 2;
        int newPos = 5;
        PositionToShift(arr, n, oldPos, newPos);       
    }
}

