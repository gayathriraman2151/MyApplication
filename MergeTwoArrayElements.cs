using System;
using System.Linq;

public class MergeTwoArrayElements
{
    public static void Main(String[] args)
    {
        //Merge two array elements and remove duplicates.
        int[] arr = { 1, 2, 3, 7, 5, 20 };
        int[] arr2 = { 1, 6, 7, 5, 80 };
        
        var final = arr.Union(arr2).ToArray();
        Array.Sort(final);
        Console.WriteLine("New array:");
        Array.ForEach(final, i => Console.WriteLine(i));
    }
}
