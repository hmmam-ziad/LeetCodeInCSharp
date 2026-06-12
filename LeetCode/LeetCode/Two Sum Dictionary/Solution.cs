using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Sum_Dictionary
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/description/
    /// </summary>
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
