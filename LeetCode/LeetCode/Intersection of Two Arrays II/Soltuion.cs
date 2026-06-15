using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Intersection_of_Two_Arrays_II
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-arrays-ii/description/
    /// </summary>
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> result = new List<int>();
            int j = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (map.ContainsKey(nums1[i]))
                {
                    map[nums1[i]]++;
                }
                else
                {
                    map.Add(nums1[i], 1);
                }
            }

            while (j < nums2.Length)
            {
                if (map.ContainsKey(nums2[j]) && map[nums2[j]] > 0)
                {
                    result.Add(nums2[j]);
                    map[nums2[j]]--;
                    
                }
                j++;
            }
            return result.ToArray();
        }
    }
}
