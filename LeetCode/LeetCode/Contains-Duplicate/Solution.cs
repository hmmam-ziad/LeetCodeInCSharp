using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contains_Duplicate
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/description/
    /// </summary>
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                set.Add(num);
            }
            return false;
        }
    }
}
