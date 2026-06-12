using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array_Even
{
    public class Solution
    {
        /// <summary>
        /// Write a function that takes an array of numbers and returns a new array containing only even numbers.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] EvenArr(int[] nums)
        {
            List<int> even = new List<int>();
            for (int i = 0; i< nums.Length; i++)
            {
                if (nums[i] % 2 == 0) even.Add(nums[i]);
            }

            return even.ToArray();
        }
    }
}
