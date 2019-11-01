using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            var res = nums[0];
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (res != nums[i])
                {
                    res = nums[i];
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
