using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Sum_II___Input_Array_Is_Sorted
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
    /// </summary>
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum > target) right--;
                else left++;
            }
            return new int[] { 0, 0 };
        }
    }
}
