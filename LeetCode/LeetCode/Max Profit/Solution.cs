using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Max_Profit
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
    /// </summary>
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int min = prices[0], max = 0;
            for (int i = 1; i <= prices.Length - 1; i++)
            {
                if (prices[i] < min)
                    min = prices[i];
                if (prices[i] - min > max)
                    max = prices[i] - min;
            }
            return max;
        }
    }
}
