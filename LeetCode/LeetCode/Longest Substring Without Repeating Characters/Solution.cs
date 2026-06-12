using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1) return s.Length;
            int CurrentLen, MaxLen = 0;
            string subString;
            for (int i = 0; i < s.Length; i++)
            {
                CurrentLen = 0;
                subString = "";
                for (int j = i; j < s.Length; j++)
                {
                    if (subString.Contains(s[j]))
                        break;
                    CurrentLen++;
                    subString += s[j];
                    MaxLen = Math.Max(CurrentLen, MaxLen);
                }
            }

            return MaxLen;
        }
    }
}
