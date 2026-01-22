using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Boats_to_Save_People
{
    public class Solution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            int boats = 0;
            Array.Sort(people);

            int smallest = 0;
            int biggest = people.Length - 1;
            while (biggest >= smallest)
            {
                if (people[smallest] + people[biggest] <= limit)
                {
                    
                    smallest++;
                    biggest--;
                } 
                else
                {
                    biggest--;
                }
                boats++;
            }
            return boats;
        }
    }
}
