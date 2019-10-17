using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
    /// You can use each character in text at most once.Return the maximum number of instances that can be formed.
    /// </summary>
    public class MaximumNumberofBalloons1189
    {
        /// <summary>
        /// 统计各个字符数量 l o 除2处理，然后取最小值
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int MaxNumberOfBalloons(string text)
        {
            int[] nums = new int[] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'b':
                        nums[0]++;
                        break;
                    case 'a':
                        nums[1]++;
                        break;
                    case 'l':
                        nums[2]++;
                        break;
                    case 'o':
                        nums[3]++;
                        break;
                    case 'n':
                        nums[4]++;
                        break;
                    default:
                        break;
                }
            }
            nums[2] = nums[2] / 2;
            nums[3] = nums[3] / 2;
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
        }
    }
}
