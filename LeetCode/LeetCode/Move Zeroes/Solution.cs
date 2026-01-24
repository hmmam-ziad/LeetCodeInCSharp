using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Move_Zeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int i = 0, j, temp ;
            while (i < nums.Length)
            {
                j = 0;
                while (j < nums.Length - 1)
                {
                    if (nums[j] == 0)
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                    j++;
                }
                i++;
            }
        }

        
    }
}
