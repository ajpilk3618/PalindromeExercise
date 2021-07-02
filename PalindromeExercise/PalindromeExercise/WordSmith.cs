using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            var str = input.Replace(" ", "");
            if (str == "")
            {
                return false;
            }
            var strLow = str.ToLower();
            var inputArr = strLow.ToCharArray();
            Array.Reverse(inputArr);
            var reverse = new string(inputArr);
            if (strLow == reverse)
            {
                return true;
            }
            else return false;
        }
    }
}
