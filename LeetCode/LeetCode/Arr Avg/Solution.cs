using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arr_Avg
{
    /// <summary>
    /// Write a function that takes an array of numbers and returns the arithmetic mean.
    /// </summary>
    public class Solution
    {
        public decimal ArrAvg(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return (decimal)sum / nums.Length;
        }
    }
}
