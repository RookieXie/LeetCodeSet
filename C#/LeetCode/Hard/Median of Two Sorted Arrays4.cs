using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    /**
     * There are two sorted arrays nums1 and nums2 of size m and n respectively.

    Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

    You may assume nums1 and nums2 cannot be both empty.

    Example 1:

    nums1 = [1, 3]
    nums2 = [2]

    The median is 2.0
    Example 2:

    nums1 = [1, 2]
    nums2 = [3, 4]

    The median is (2 + 3)/2 = 2.5
     * **/
    public class Median_of_Two_Sorted_Arrays4
    {
        /// <summary>
        /// 思路：同时取两个数组最后一位比较，将大的插入到新数组中，大的数组索引 -1，判断此时新数组位于何处，如果位于中间则出结果，数量i+1
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            
            int n = nums1.Length;
            int m = nums2.Length;
            int length = m + n;
            int[] list = new int[length];
            int i = 0;
            double res = 0.0;
            while (n > 0 || m > 0)
            {
                //当数组1 走空
                if (n == 0)
                {
                    list[length - i - 1] = nums2[m-1];
                    m--;
                }
                else if (m == 0)//当数组2 走空
                {
                    list[length - i - 1] = nums1[n-1];
                    n--;
                }
                else
                {
                    //判断最大值 大者插入新数组 
                    if (nums1[n - 1] > nums2[m - 1])
                    {

                        list[length - i - 1] = nums1[n-1]; 
                        n--;
                    }
                    else
                    {
                        list[length - i - 1] = nums2[m-1];
                        m--;
                    }
                }
                //判断总长度的奇偶
                if ((length + 1) % 2 == 0)
                {
                    //奇数 长度中间为返回结果 退出循环
                    if (length / 2 == i)
                    {
                        res = list[i];
                        break;
                    }

                }
                else
                {
                    //偶数 两边为返回结果 退出循环
                    if (length / 2 == i)
                    {
                        res = (list[i] + list[i - 1]) / 2.0;
                        break;
                    }
                   
                }
                i++;
            }
            return res;
        }
    }
}
