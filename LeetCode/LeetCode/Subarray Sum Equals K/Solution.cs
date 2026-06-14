using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Subarray_Sum_Equals_K
{
    /// <summary>
    /// https://leetcode.com/problems/subarray-sum-equals-k/description/
    /// </summary>
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            int currentSum = 0, count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                if (map.ContainsKey(currentSum - k))
                    count += map[currentSum - k];

                if (map.ContainsKey(currentSum))
                    map[currentSum]++;
                else
                    map[currentSum] = 1;
            }

            return count;
        }
    }
}
