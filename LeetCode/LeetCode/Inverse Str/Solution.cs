using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Inverse_Str
{
    public class Solution
    {
        /// <summary>
        /// Write a function that takes a string and returns it in reverse. For example, "hello" → "olleh".
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReveseStr(string s)
        {
            char[] arr = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[s.Length - 1 - i];
            }

            return new string(arr);
        }
    }
}
