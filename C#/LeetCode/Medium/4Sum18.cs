using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

        Note:

        The solution set must not contain duplicate quadruplets.

        Example:

        Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

        A solution set is:
        [
          [-1,  0, 0, 1],
          [-2, -1, 1, 2],
          [-2,  0, 0, 2]
        ]
     * **/
    public class _4Sum18
    {
        /// <summary>
        /// 思路 整体处理 原数组排序， 分四层 一次 i  s  t  f  
        /// 当 i=0 时 s=1 t=2,f=3 即s=i+1,t=s+1;f=t+1；
        ///  在遍历f时 判断与目标值
        ///  每一层while  过滤掉重复值
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> lists = new List<IList<int>>();
            int length = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < length - 3; i++)
            {
                
                for (int s = i+1; s < length-2; s++)
                {
                   
                    for (int t = s+1; t < length-1; t++)
                    {
                     
                        for (int f = t+1; f < length; f++)
                        {
                            int  res = nums[i] + nums[s]+ nums[t]+ nums[f];
                            if (target == res)
                            {
                                List<int> vs = new List<int>() { nums[i] , nums[s], nums[t], nums[f] };
                                
                                lists.Add(vs);
                            }
                            ///过滤重复
                            while (f<length-1 &&nums[f] == nums[f + 1])
                            {
                                f++;
                            }
                        }
                        ///过滤重复
                        while (t < length - 1 && nums[t] == nums[t + 1])
                        {
                            t++;
                        }
                    }
                    ///过滤重复
                    while (s < length - 1 && nums[s] == nums[s + 1])
                    {
                        s++;
                    }
                }
                
            }
            
            return lists;
        }
    }
}
