using System;
using System.Collections.Generic;
using System.Linq;

class StringIsPalindrome
{

    private static string ReverseAString(string s)
    {
        char[] strPalindrome = s.ToCharArray();
        Array.Reverse(strPalindrome);
        return new String(strPalindrome);

    }
    public static void Main(String[] args)
    {
        string strPalindrome = "";
        if (strPalindrome == "")
        {
            Console.WriteLine("String cannot be blank");
            return;
        }
        string reverseString = ReverseAString(strPalindrome);
        if (strPalindrome == reverseString)
        {
            Console.WriteLine("String is Palindrome");
        }
        else
        {
            Console.WriteLine("String is not a Palindrome");
        }

    }

}

