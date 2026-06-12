using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sum_First_And_Last
{
    /// <summary>
    /// Write a function that takes an array and returns the sum of the first and last elements.
    /// </summary>
    public class Solution
    {
        public int SumFirstAndLast(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            return nums[0] + nums[nums.Length - 1];
        }
    }
}
