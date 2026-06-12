using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Revers_Nums
{
    /// <summary>
    /// Write a function that takes an array and returns a new array containing the same numbers but in reverse order — without using any built-in reverse.
    /// </summary>
    public class Solution
    {
        public int[] ReverseArr(int[] arr)
        {
            int[] reverseArr = new int[arr.Length];
            for(int i = 0; i <= arr.Length - 1; i++)
            {
                reverseArr[arr.Length - i - 1] = arr[i];
            }
            return reverseArr;
        }
    }
}
