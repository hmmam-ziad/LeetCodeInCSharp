using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Bigger_Than_Zero
{
    /// <summary>
    /// Write a function that takes an array and returns the number of numbers greater than zero.
    /// </summary>
    public class Solution
    {
        public int CountBiggerThanZero(int[] nums)
        {
            int count = 0;
            foreach(int num in nums)
            {
                if(num > 0)
                    count++;
            }
            return count;
        }
    }
}
