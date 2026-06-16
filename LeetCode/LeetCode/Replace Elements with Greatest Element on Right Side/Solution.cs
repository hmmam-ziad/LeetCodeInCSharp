using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Replace_Elements_with_Greatest_Element_on_Right_Side
{
    /// <summary>
    /// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    /// </summary>
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            int max = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int newMax = Math.Max(max, arr[i]);
                arr[i] = max;
                max = newMax;
            }

            return arr;
        }
    }
}
