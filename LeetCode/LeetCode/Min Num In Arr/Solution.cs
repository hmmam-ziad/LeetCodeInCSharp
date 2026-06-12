using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Min_Num_In_Arr
{
    /// <summary>
    /// Write a function that takes an array and returns the smallest number in it.
    /// </summary>
    public class Solution
    {
        public int MinNum(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
