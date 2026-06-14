using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Plus_One
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/description/
    /// </summary>
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newArr = new int[digits.Length + 1];
            newArr[0] = 1;
            return newArr;
        }
    }
}
