using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int res = 0;
            for (int i = 0; i < nums.Length;i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }
                else
                {
                    res++;
                }
            }
            return res;
        }
    }
}
