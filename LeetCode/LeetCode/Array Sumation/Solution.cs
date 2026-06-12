using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array_Sumation
{
    /// <summary>
    /// Write a function that takes an array of numbers and returns their sum.
    /// </summary>
    public class Solution
    {
        public int ArraySum(int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }

            return sum;
        }
    }
}
