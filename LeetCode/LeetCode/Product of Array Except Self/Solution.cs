using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Product_of_Array_Except_Self
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/description/
    /// </summary>
    public class Solution
    {
        public static int[] ArrayExceptSelf(int[] nums)
        {
            int[] productArr = new int[nums.Length];
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];
            prefix[0] = 1;
            suffix[nums.Length - 1] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i - 1];
            }
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1];
            }
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                productArr[i] = prefix[i] * suffix[i];
            }
            return productArr;
        }
    }
}
