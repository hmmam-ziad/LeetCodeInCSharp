using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.The_Difference_Between_Max_And_Min
{
    /// <summary>
    /// Write a function that takes an array and returns the difference between the largest and smallest numbers in it.
    /// </summary>
    public class Solution
    {
        public int Differnce(int[] nums)
        {
            int max = nums[0], min = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] < min) min = nums[i];
                if(nums[i] > max) max = nums[i];
            }

            return max - min;
        }
    }
}
