using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Prime_Num
{
    public class Solution
    {
        /// <summary>
        /// Write a function that takes an integer and returns true if it is prime and false if it is not.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
