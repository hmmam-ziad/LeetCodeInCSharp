using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Pascals_Traiangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                row.Add(1);
                if (i > 0)
                {
                    List<int> prevRow = (List<int>)result[i - 1];
                    for (int j = 1; j < i; j++)
                    {
                        row.Add(prevRow[j - 1] + prevRow[j]);
                    }
                    row.Add(1);
                }

                result.Add(row);

            }

            return result;
        }
    }
}
