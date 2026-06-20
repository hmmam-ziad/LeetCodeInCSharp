using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Once_Element
{
    /// <summary>
    /// Write a function that takes an array of numbers and returns a new array containing only the numbers that appeared only once.
    /// </summary>
    public class Solution
    {
        public int[] OnceArr(int[] nums)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if(map.ContainsKey(num)) map[num]++;
                else map.Add(num, 1);
            }

            foreach (int item in nums)
            {
                if (map[item] == 1) result.Add(item);
            }

            return result.ToArray();
        }
    }
}
