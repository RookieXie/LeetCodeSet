using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            int sum = nums[0];
            int temp = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (temp < 0) { temp = nums[i]; } else { temp += nums[i]; }
                sum=Math.Max(temp, sum);
            }
            return sum;
        }
    }
}
