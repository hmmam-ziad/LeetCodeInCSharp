using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Valid_Anagram
{
    /// <summary>
    /// https://leetcode.com/problems/valid-anagram/description/
    /// </summary>
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] count = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }
            for(int i = 0; i < 26; i++)
            {
                if (count[i] != 0) return false;
            }
            return true;
        }
    }
}
