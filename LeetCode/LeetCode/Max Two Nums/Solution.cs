using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Max_Two_Nums
{
    /// <summary>
    /// Write a function that takes two numbers and returns the larger one. If they are equal, return either one.
    /// </summary>
    public class Solution
    {
        public int MaxTwoNums(int num1, int num2)
        {
            return num1 >= num2 ? num1 : num2;
        }
    }
}
