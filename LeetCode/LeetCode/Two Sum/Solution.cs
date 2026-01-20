using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            int[] idxs = new int[2];
            int sum = 0;
            for (int s = 0; s < len; s++)
            {
                for (int e = s + 1; e < len; e++)
                {
                    sum = nums[e] + nums[s];
                    if (sum == target)
                    {
                        idxs[0] = s;
                        idxs[1] = e;
                        return idxs;
                    }
                }
            }
            return [];
        }
    }
}
