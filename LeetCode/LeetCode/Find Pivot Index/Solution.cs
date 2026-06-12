using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Find_Pivot_Index
{
    /// <summary>
    /// https://leetcode.com/problems/find-pivot-index/description/
    /// </summary>
    public class Solution
    {
        public static int PivotIndex(int[] nums)
        {
            int totalSum = nums.Sum();
            int leftSum = 0, rightSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum = totalSum - leftSum - nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
