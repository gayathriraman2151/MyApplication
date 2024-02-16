using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestPositiveNUmber
{
    internal class Program
    {
        public static int ResultNumber(int[] A)
        {
            /* First Draft
            int ans = 1;
            bool availNum = false;
            bool lessThanZero = false;
            HashSet<int> set = new(A);
            for (int i = 1; i <= A.Length; i++)
            {
                if (!set.Contains(i))
                {
                    ans = i;
                    availNum = false;
                    break;                   
                }
                else if (A[i - 1] < 0)
                {
                    lessThanZero = true;
                }
                else
                {
                    availNum = true;
                    lessThanZero = false;
                }
                              
            }
            if (lessThanZero)
            {
                ans = 1;
            }
            if (availNum) {
                ans = A.Max() + 1;
            }
            
            return ans;
            */

            // improved performance code
            HashSet<int> set = new(A);
            int ans = 1;

            ans = Math.Max(ans, A.Max() + 1);

            if (A.Any(num => num < 0))
            {
                ans = 1;
            }

            for (int i = 1; i <= A.Length; i++)
            {
                if (!set.Contains(i))
                {
                    ans = i;
                    break;
                }
            }         

            return ans;

        }
        static void Main(string[] args)
        {
            int[] A = { 0,1,2,4};
            int ans = ResultNumber(A);
            Console.WriteLine("Smallest Missing Number: " + ans);
        }
    }
}

