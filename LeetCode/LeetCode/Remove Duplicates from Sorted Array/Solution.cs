using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Remove_Duplicates_from_Sorted_Array
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    /// </summary>
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] != nums[k - 1])
                {
                    nums[k++] = nums[i];
                }
            }

            return k;
        }
    }
}
