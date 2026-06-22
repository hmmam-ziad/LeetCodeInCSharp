using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Palindrome_Str
{
    public class Solution
    {
        public bool IsPalindrome(string str)
        {
            if (str.Length == 1) return true;
            bool isPalindrome = false;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == str[str.Length - i - 1]) isPalindrome = true;
                else return false;
            }
            return isPalindrome;
        }
    }
}
