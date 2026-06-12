using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Move_Zeroes
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/description/
    /// </summary>
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int temp = 0;
            int k = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] != 0)
                {
                    temp = nums[k];
                    nums[k] = nums[i];
                    nums[i] = temp;
                    k++;
                }
            }
        }

        
    }
}
