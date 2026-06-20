using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.The_Element_Before_Them
{
    /// <summary>
    /// Write a function that takes an array and returns the number of elements that are greater than the element preceding them.
    /// </summary>
    public class Solution
    {
        public int BigBefor(int[] nums)
        {
            int count = 0;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1]) count++;
            }

            return count;
        }
    }
}
