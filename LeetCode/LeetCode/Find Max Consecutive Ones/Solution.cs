using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Find_Max_Consecutive_Ones
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int MaxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    MaxCount = Math.Max(MaxCount, count);
                }
                else
                    count = 0;
            }
            return MaxCount;
        }
    }
}
