using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sort_Colors
{
    /// <summary>
    /// https://leetcode.com/problems/sort-colors/description/
    /// </summary>
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int temp = 0, length = nums.Length - 1;
            int low = 0, mid = 0, high = length;
            while(mid <= high)
            {
                if (nums[mid] == 0)
                {
                    temp = nums[mid];
                    nums[mid] = nums[low];
                    nums[low] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else if (nums[mid] == 2)
                {
                    temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }
        }
    }
}
