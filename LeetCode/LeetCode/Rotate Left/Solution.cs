using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Rotate_Left
{
    /// <summary>
    /// Write a function that takes an array and a number *n*, and rotates the array to the left by *n* steps.
    /// </summary>
    public class Solution
    {
        public int[] RotateLeft(int[] arr, int n)
        {
            if (arr == null || arr.Length <= 1) return arr;

            int length = arr.Length;

            n = n % length;

            if (n < 0)
            {
                n += length;
            }

            if (n == 0) return arr ;

            Reverse(arr, 0, n - 1);

            Reverse(arr, n, length - 1);

            Reverse(arr, 0, length - 1);

            return arr;
        }

        private void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

    }
}
