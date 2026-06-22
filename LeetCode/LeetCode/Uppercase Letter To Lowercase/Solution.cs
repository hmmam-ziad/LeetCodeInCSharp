using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Uppercase_Letter_To_Lowercase
{
    /// <summary>
    /// Write a function that takes a string and converts every uppercase letter to lowercase—without using `.ToLower()`.
    /// </summary>
    public class Solution
    {
        public string ToLowercase(string s)
        {
            char[] chars = s.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)(chars[i] + 32);
                }
            }
            return new string(chars);
        }
    }
}
