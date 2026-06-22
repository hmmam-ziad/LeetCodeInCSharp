using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Is_All_Nums_In_Str
{
    /// <summary>
    /// Write a function that takes a string and returns `true` if all its characters are digits.
    /// </summary>
    public class Solution
    {
        public bool IsAllNums(string s)
        {
            bool isAll = false;

            for(int i = 0; i< s.Length; i++)
            {
                if (s[i] >= 48 &&  s[i] <= 57) { isAll = true; }
                else return false;
            }

            return isAll;
        }
    }
}
