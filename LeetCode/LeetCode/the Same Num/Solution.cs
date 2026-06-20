using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.the_Same_Num
{
    /// <summary>
    /// Write a function that takes an array and returns a new array where each element is repeated twice—for example, [1, 2, 3] → [1, 1, 2, 2, 3, 3].
    /// </summary>
    public class Solution
    {
        public int[] SameArr(int[] nums)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map.Add(nums[i], 1);
                }

                if (map[nums[i]] == 2)
                {
                    result.Add(nums[i]);
                }
            }
            return result.ToArray();
        }
    }
}
