using System;
using System.Collections.Generic;

class RemoveSubsequentDuplicates
{
    //Remove subsequent duplicate items in the array.

    public static void Main(String[] args)
    {
        //Creating a hash set
        HashSet<int> hsRemoveSubsequentDupes = new HashSet<int>();

        int[] arrayList = { 1, 2, 3, 3, 4, 5, 5, 5 };
        int arrayLength = arrayList.Length;
        
        //Looping through Array
        for (int i = 0; i < arrayLength; i++)
        {

            if (!hsRemoveSubsequentDupes.Contains(arr[i]))
            {
                hsRemoveSubsequentDupes.Add(arr[i]);
            }

        }
        
        // Display Elements
        foreach (var element in hsRemoveSubsequentDupes)
        {
            Console.WriteLine(element);
        }
    }

}

/* 
Output:

1
2
3
4
5
 */
*/
 */
 */