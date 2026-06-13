using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Single_Number
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/description/
    /// </summary>
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result = result ^ num;
            }
            return result;
        }
    }
}
