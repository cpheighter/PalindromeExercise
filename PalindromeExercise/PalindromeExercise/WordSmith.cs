using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string x)
        {
            string reverse = new string (x.Reverse().ToArray());
            if (reverse == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
