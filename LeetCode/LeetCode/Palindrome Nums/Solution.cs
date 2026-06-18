using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Palindrome_Nums
{
    /// <summary>
    /// Write a function that takes an array and returns `true` if it is a palindrome—meaning it reads the same forwards and backwards (e.g., `[1, 2, 3, 2, 1]`).
    /// </summary>
    public class Solution
    {
        public bool PalindromeNums(int[] nums)
        {
            bool isPalindrome = false;

            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] == nums[right])
                {
                    isPalindrome = true;
                }
                else
                {
                    return false;
                }
                left++;
                right--;
            }

            return isPalindrome;
        }
    }
}
