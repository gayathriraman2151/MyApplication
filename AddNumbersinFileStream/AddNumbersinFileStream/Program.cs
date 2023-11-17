using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbersinFileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content;
            //Read file from a file 
            var fileStream = new FileStream(@"c:\GIT\PuzzleInput.txt", FileMode.Open, FileAccess.Read);
            using (var sr = new StreamReader(fileStream))
            {
                content = sr.ReadToEnd();
            }

            string[] myArrayList = content.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);
                    
            List<int> listTotalCountArr = new List<int>();
            int totalCount = 0;

            foreach (string str in myArrayList)
            { 
                   
                if (str != "")
                {
                    int numberValue = Convert.ToInt32(str);
                    totalCount += numberValue;
                   
                }                
                else if (str=="")
                {
                    listTotalCountArr.Add(totalCount);
                    totalCount = 0;
                }
            }
            int maxVal = listTotalCountArr.Max();
            Console.WriteLine("Highest Total: " + maxVal);
           
           
        }
    }
}
