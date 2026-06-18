using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Sum_Boolean
{
    /// <summary>
    /// Write a function that takes an array and a target number, and returns `true` if the sum of any two consecutive numbers equals the target.
    /// </summary>
    public class Solution
    {
        public bool TwoSum(int[] nums, int target)
        {
            for(int i  = 0; i < nums.Length - 1; i++)
            {
                int sum = nums[i] + nums[i + 1];
                if(sum == target) return true;
            }
            return false;
        }
    }
}
