using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Majority_Element
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/description/
    /// </summary>
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int candidate = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }
                if (nums[i] == candidate) count++;
                else count--;
            }
            return candidate;
        }
    }
}
