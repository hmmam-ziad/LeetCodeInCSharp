using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Bigger_Than_Avg
{
    /// <summary>
    /// Write a function that takes an array and returns a new array containing the numbers that are greater than the arithmetic mean.
    /// </summary>
    public class Solution
    {
        public int[] BiggerThanAvg(int[] nums)
        {
            int sum = 0;
            double avg = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            avg = (double)sum / nums.Length;
            List<int> bigThanAvg = new List<int>();
            foreach (int num in nums)
            {
                if (num > avg)
                    bigThanAvg.Add(num);
            }

            return bigThanAvg.ToArray();
        }
    }
}
