using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Reverses_Words
{
    /// <summary>
    /// Write a function that takes a string and reverses the order of the words—for example, "hello world" → "world hello".
    /// </summary>
    public class Solution
    {
        public string ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            string result = "";

            for(int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i];
                if (i != 0) result += " ";
            }

            return result;
        }
    }
}
