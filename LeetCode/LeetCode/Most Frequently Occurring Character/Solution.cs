using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Most_Frequently_Occurring_Character
{
    /// <summary>
    /// Write a function that takes a string and returns the most frequently occurring character in it.
    /// </summary>
    public class Solution
    {
        public char MostChar(string s)
        {
            int max = 0;
            char c = ' ';
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char item in s)
            {
                if (map.ContainsKey(item)) map[item]++;
                else map.Add(item, 1);
            }

            foreach (char item in s)
            {
                if (map[item] > max)
                {
                    max = map[item];
                    c = item;
                }
            }

            return c;
        }
    }
}
