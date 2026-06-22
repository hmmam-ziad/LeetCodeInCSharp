using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Count_Words
{
    /// <summary>
    /// Write a function that takes a string and returns the number of words in it—where words are separated by spaces.
    /// </summary>
    public class Solution
    {
        public int CountWordsWithoutSpaces(string str)
        {
            int count = str[0] == ' ' ? 0 : 1;
            for(int i  = 0; i < str.Length; i++)
            {
                if(str[i] == ' ' && str[i + 1] != ' ') count++;
            }
            return count;
        }
    }
}
