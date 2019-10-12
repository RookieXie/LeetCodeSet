using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MedianofTwoSortedArrays
    {
        /// <summary>
        /// 未完成
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len = (nums1.Length + nums2.Length) / 2;
            bool isJs = false;
            if ((nums1.Length + nums2.Length) % 2 == 0)
            {
                isJs = false;
            }
            else
            {
                isJs = true;
            }
            int k = 0;
            int m = 0;
            for (int i = nums1.Length; i > 0; i--)
            {
                if (isJs)
                {
                    if (k == len)
                    {
                        return Math.Round(nums1[k] * 1.0, 1);

                    }
                }
                else
                {
                    if (k == len)
                    {
                        return Math.Round((nums1[k-1] + nums2[m - 1]) / 2.0, 1);
                    }
                }
                for (int j = nums2.Length; j > 0; j--)
                {

                   
                    if (isJs)
                    {
                        if (k == len)
                        {
                            return Math.Round(nums2[j-1] * 1.0, 1);
                        }
                    }
                    else
                    {
                        if (k == len)
                        {
                            return Math.Round((nums1[i-1] + nums2[j-1])/2.0, 1);
                        }
                    }
                    k++;
                    if (nums1[i-1] >= nums2[j-1])
                    {
                        m = j - 1;
                        break;
                    }
                }
            }

            return 0;
        }
    }
}
