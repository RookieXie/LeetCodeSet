using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ThreeSumClosestClass
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            int res = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < length - 1; i++)
            {
                int lo = i+1, hi = length - 1;

                while (lo != hi)
                {
                    int temp = nums[lo] + nums[hi] + nums[i];
                    if (temp <= target)
                    {
                        if (Math.Abs(temp - target) < Math.Abs(res - target))
                        {
                            res = temp;
                        }
                        lo++;
                    }
                    else
                    {
                        if (Math.Abs(temp - target) < Math.Abs(res - target))
                        {
                            res = temp;
                        }
                        hi--;
                    }
                }
            }
            return res;
        }
    }
}
