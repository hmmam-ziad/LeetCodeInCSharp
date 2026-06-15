using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Duplicate_Zeros
{
    /// <summary>
    /// https://leetcode.com/problems/duplicate-zeros/description/
    /// </summary>
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = arr.Length - 1; j != i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    i += 1;
                    if(i < arr.Length)
                    {
                        arr[i] = 0;
                    }
                }
            }
        }
    }
}
