using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sum_Arr_Positive
{
    /// <summary>
    /// Write a function that takes an array of numbers and returns the sum of only the positive numbers.
    /// </summary>
    public class Solution
    {
        public int SumOfPositive(int[] arr)
        {
            int sum = 0;
            foreach (var posNum in arr)
            {
                if(posNum > 0) 
                    sum += posNum;
            }
            return sum;
        }
    }
}
