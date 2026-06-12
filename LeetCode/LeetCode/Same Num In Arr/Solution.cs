using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Same_Num_In_Arr
{
    /// <summary>
    /// Write a function that takes an array and returns true if there is a duplicate number, false if not.
    /// </summary>
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            for(int i = 0; i <= nums.Length - 1; i++)
            {
                for(int j = nums.Length - 1; j>=0; j--)
                {
                    if (i != j && nums[i] == nums[j])
                        return true;
                }
            }
            return false;
        }
    }
}
