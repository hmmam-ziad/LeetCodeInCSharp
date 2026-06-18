using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Squares_of_a_Sorted_Array
{
    /// <summary>
    /// https://leetcode.com/problems/squares-of-a-sorted-array/description/
    /// </summary>
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int p1 = 0, p2 = nums.Length - 1;
            int pos = nums.Length - 1;
            int[] result = new int[nums.Length];

            while (p1 <= p2)
            {
                int left = nums[p1] * nums[p1];
                int right = nums[p2] * nums[p2];
                if (right > left)
                {
                    result[pos--] = right;
                    p2--;
                }
                else
                {
                    result[pos--] = left;
                    p1++;
                }
            }
            return result;
        }
    }
}
