using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Num_More_repete_In_Arr
{
    /// <summary>
    /// Write a function that takes an array and returns the number of times the most frequently occurring number is repeated.
    /// </summary>
    public class Solution
    {
        public int[] NumMoreRepete(int[] nums)
        {
            int[] count = new int[nums.Length];
            //Array.Fill(count, 1);
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count[i]++;
                    }
                }
            }

            int max = count[0], idx = 0;
            for (int i = 0; i <= count.Length - 1; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    idx = i;
                }
            }

            return new[] { max + 1, nums[idx] };
        }
    }
}
