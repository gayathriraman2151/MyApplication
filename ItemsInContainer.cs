using System;
using System.Collections.Generic;
using System.Linq;

class ItemsInContainer
{ 
    private static void OpenClosed(string s, int[] startindices, int[] endindices)
    {
        // Length of Array
        int count = startindices.Length;
        // List and Array Definition
        List<string> indices = new List<string>();
        int[] starCount = new int[startindices.Length];
        int startindex = 0;
        int endindex = 0;

        // Fetch Start and End Index value
        // In the Indices list add the string based on start and end indices
        for (int i = 0; i < count; i++)
        {
            startindex = startindices[i];
            endindex = endindices[i];
            indices.Add(s.Substring(startindex - 1, endindex));
        }

        int[] finalCount = new int[count];
        int increment = 0;
        indices.ForEach(delegate (string name)
        {
            // Get the lastindex of pipe to get the star from start index to end index
            int lastPipe = name.LastIndexOf('|');
            char[] countStar = name.Substring(0, lastPipe + 1).ToCharArray();

            //Loop through the countStar Array to get the count of star in between the pipe
            int star = 0;
            foreach (var cs in countStar)
            {
                if (cs == '*')
                {
                    star++;
                }
            }

            finalCount[increment] = star;
            increment++;

        });
        Console.WriteLine("Final Output: " + "[{0}]", string.Join(", ", finalCount));
    }

    public static void Main(String[] args)
    {

        int[] startindices = { 1, 1 };
        int[] endindices = { 4, 16 };
        string s = "|**|*|*****|***|";
        OpenClosed(s, startindices, endindices);

    }    
}
/*
Output:

Final Output: [2, 11]
 */