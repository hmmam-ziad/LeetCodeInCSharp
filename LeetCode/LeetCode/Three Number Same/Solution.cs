using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Three_Number_Same
{
    /// <summary>
    /// Write a function that takes an array and returns `true` if it contains three consecutive identical numbers—for example, `[1, 2, 2, 2, 3]`.
    /// </summary>
    public class Solution
    {
        public bool IsThreeNumSame(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if(map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map.Add(nums[i], 1);
                }

                if (map[nums[i]] == 3)
                {
                    return true;
                }
            }

            return false;

        }       
    }
}
