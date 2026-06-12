using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Check_Even_And_Odd
{
    /// <summary>
    /// Write a function that takes an integer and returns true if it is even and false if it is odd.
    /// </summary>
    public class Solution
    {
        public bool CheckEvenOdd(int num)
        {
            if(num % 2 == 0)
                return true;

            return false;
        }
    }
}
