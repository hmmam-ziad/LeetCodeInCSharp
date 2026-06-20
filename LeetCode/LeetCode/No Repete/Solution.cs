using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.No_Repete
{
    /// <summary>
    /// Write a function that takes an array and returns `true` if all its elements are unique (no duplicates)—without using a `HashSet`; that is, using a nested loop.
    /// </summary>
    public class Solution
    {
        public bool IsNotRepeted(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[j] == nums[i])
                        return false;
                }
            
            }

            return true;
        }
    }
}
