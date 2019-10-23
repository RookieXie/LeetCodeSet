using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * A self-dividing number is a number that is divisible by every digit it contains.

        For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

        Also, a self-dividing number is not allowed to contain the digit zero.

        Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.

        Example 1:
        Input: 
        left = 1, right = 22
        Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
        Note:

        The boundaries of each input argument are 1 <= left <= right <= 10000.
     * **/
    public class SelfDividingNumbers728
    {
        /// <summary>
        /// 从个位开始验证，以10为倍数
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> res = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if(Dividing(i, i))
                {
                    res.Add(i);
                }

            }
            return res;
        }

        public bool Dividing(int orign, int mid)
        {
            bool isDeivid = false;
            int temp = mid / 10;
            int next = mid % 10;

            if (next!=0 &&orign % next == 0)
            {
                isDeivid = true;
                if (temp > 0)
                {
                    isDeivid = Dividing(orign, temp);
                }
            }
            return isDeivid;
        }
    }
}
