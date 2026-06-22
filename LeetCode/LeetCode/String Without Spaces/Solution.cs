using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String_Without_Spaces
{
    /// <summary>
    /// Write a function that takes a string and returns it without spaces.
    /// </summary>
    public class Solution
    {
        public string StringWithoutSpaces(string s)
        {
            string deStr = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') deStr += s[i];
            }
            return deStr;
        }
    }
}
