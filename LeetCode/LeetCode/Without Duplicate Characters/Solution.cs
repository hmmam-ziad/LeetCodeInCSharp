using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Without_Duplicate_Characters
{
    /// <summary>
    /// Write a function that takes a string and returns it without duplicate characters—for example, "aabbcc" → "abc".
    /// </summary>
    public class Solution
    {
        public string WithoutDuplicates(string s)
        {
            string result = "";
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s) {
                if (map.ContainsKey(c)) { 
                    map[c] = map[c] + 1;
                }
                else
                {
                    map.Add(c, 1);
                    result += c;
                }
            
            }


            return result;
        }
    }
}
