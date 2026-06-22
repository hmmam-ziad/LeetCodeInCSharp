using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.First_Non_Repeating_Character
{
    /// <summary>
    /// Write a function that takes a string and returns the first non-repeating character—for example, given "aabbc", it returns 'c'.
    /// </summary>
    public class Solution
    {
        public char FirstNonRepetingCharacter(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char item in s)
            {
                if(map.ContainsKey(item))
                    map[item]++;
                else map.Add(item, 1);
            }

            foreach (char item in s)
            {
                if (map[item] == 1) return item;
            }
            return ' ';
        }
    }
}
