using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Char_Count
{
    /// <summary>
    /// Write a function that takes a string and calculates how many times a certain character is repeated in it.
    /// </summary>
    public class Solution
    {
        public int CharCount(string s, char c)
        {
            int count = 0;
            foreach(char ch in s)
            {
                if (ch == c) count++;
            }

            return count;
        }
    }
}
