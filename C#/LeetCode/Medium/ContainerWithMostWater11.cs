
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ContainerWithMostWater11
    {
        /// <summary>
        /// Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai).
        /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0).
        /// Find two lines, which together with x-axis forms a container, such that the container contains 
        /// the most water.
        /// Note: You may not slant the container and n is at least 2.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            
            int maxVal = 0;
            int right = height.Length - 1;
            int left = 0;
            while (right!=left){
                
                if (height[left] < height[right])
                {
                    int temp = height[left];
                    maxVal = Math.Max(maxVal, temp * (right - left));
                    left++;
                }
                else
                {
                    int temp = height[right];
                    maxVal = Math.Max(maxVal, temp * (right - left));
                    right--;
                }
                
            }
           
            return maxVal;
        }
        /// <summary>
        /// O(n*n)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea1(int[] height)
        {
            int maxVal = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int tH = height[j];
                    if (height[j] > height[i])
                    {
                        tH = height[i];
                    }
                    int temp = (j - i) * tH;
                    if (maxVal <= temp)
                    {
                        maxVal = temp;
                    }
                }
            }
            return maxVal;
        }
    }
}
