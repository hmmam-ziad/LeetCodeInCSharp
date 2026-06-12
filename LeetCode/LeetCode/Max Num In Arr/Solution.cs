using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Max_Num_In_Arr
{
    /// <summary>
    /// Write a function that takes an array of numbers and returns the largest number in it.
    /// </summary>
    public class Solution
    {
        public int MaxNumInArr(int[] arr)
        {
            int max = arr[0];
            foreach(int num in arr)
            {
                if (num > max) max = num;
            }

            return max;
        }
    }
}
