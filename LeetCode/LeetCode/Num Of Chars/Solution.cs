using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Num_Of_Chars
{
    /// <summary>
    /// Write a function that takes a string and returns the number of characters in it (without using .Length).
    /// </summary>
    public class Solution
    {
        public int CharacterCount(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }

            return count;
        }
    }
}
