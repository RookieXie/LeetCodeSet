using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class Pascal_sTriangle118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();           
            for (int i = 0; i < numRows; i++)
            {
                IList<int> list = new List<int>();
                if (i < 2)
                {
                    for (int t = 0; t <= i; t++)
                    {
                        list.Add(1);
                    }
                }
                else
                {
                    list.Add(1);
                    for (int t = 1; t < i; t++)
                    {
                        list.Add(res[i-1][t - 1] + res[i - 1][t]);
                    }
                    list.Add(1);
                }               
                res.Add(list);
            }
            return res;
        }
    }
}
