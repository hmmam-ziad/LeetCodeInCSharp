using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Maximum_Subarray
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/description/
    /// </summary>
    public class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = nums[0];
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                if (currentSum > maxSum)
                    maxSum = currentSum;
            }

            return maxSum;
        }
    }
}
