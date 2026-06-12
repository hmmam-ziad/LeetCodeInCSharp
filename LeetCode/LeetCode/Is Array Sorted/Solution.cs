using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Is_Array_Sorted
{
    /// <summary>
    /// Write a function that takes an array and returns true if it is sorted in ascending order, false if not.
    /// </summary>
    public class Solution
    {
        public static bool isArraySorted(int[] nums)
        {
            bool isSorted = false;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if(i == nums.Length - 1 || nums[i] <= nums[i + 1])
                {
                    isSorted = true;
                }
                else
                {
                    isSorted = false;
                    break;
                }
            }
            return isSorted;
        }
    }
}
