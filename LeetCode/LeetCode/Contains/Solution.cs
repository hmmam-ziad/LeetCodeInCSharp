using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contains
{
    /// <summary>
    /// Write a function that takes two strings and returns `true` if the second is found within the first—without using `.Contains()`.
    /// </summary>
    public class Solution
    {
        public bool Contains(string str1, string str2) { 
            bool isContains = false;
            bool[] bools = new bool[str2.Length];
            Array.Fill(bools, false);
            for(int i = 0; i < str2.Length; i++)
            {
                for(int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j]) { bools[i] = true; }
                }
            }

            foreach (var item in bools)
            {
                if (item) isContains = true;
                else isContains = false;
            }
            return isContains;
        }
    }
}
