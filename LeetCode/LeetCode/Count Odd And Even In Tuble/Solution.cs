using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Count_Odd_And_Even_In_Tuble
{
    /// <summary>
    /// Write a function that takes an array of numbers and returns the count of even and odd numbers as a tuple or an array containing two elements.
    /// </summary>
    public class Solution
    {
        public (int odd, int even) CountOddAndEven(int[] nums) {
            (int odd, int even) count = new(0, 0);

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count.even++;
                }
                else
                {
                    count.odd++;
                }
            }

            return count;
        } 
    }
}
