using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Container_with_most_water
{
    public class Solution
    {
        public int MaxArea(int[] heigth)
        {
            int maxArea = 0;
            int l = 0;
            int r = heigth.Length - 1;
            while (l < r)
            {
                maxArea = Math.Max(maxArea, Math.Min(heigth[l], heigth[r]) * (r - l));
                if (heigth[l] < heigth[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return maxArea;
        }
    }
}
