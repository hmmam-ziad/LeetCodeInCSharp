using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Find_Num_In_Arr
{
    /// <summary>
    /// Write a function that takes an array and a number k, and returns true if k is present in the array.
    /// </summary>
    public class Solution
    {
        public bool FindNum(int[] nums, int k)
        {
            foreach (int num in nums)
            {
                if (num == k) return true;
            }
            return false;
        }
    }
}
