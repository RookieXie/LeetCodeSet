using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     A valid parentheses string is either empty (""), "(" + A + ")", or A + B, where A and B are valid parentheses strings, and + represents string concatenation.  For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.

A valid parentheses string S is primitive if it is nonempty, and there does not exist a way to split it into S = A+B, with A and B nonempty valid parentheses strings.

Given a valid parentheses string S, consider its primitive decomposition: S = P_1 + P_2 + ... + P_k, where P_i are primitive valid parentheses strings.

Return S after removing the outermost parentheses of every primitive string in the primitive decomposition of S.
         */
    public class RemoveOutermostParentheses1021
    {
        /// <summary>
        /// 思路：遍历 ( 计数 ）计数； 计数相同并且不是1删除
        /// </summary>
        /// <param name="S"></param>
        /// <returns>2019-10-18</returns>
        public string RemoveOuterParentheses(string S)
        {
            int k1 = 0;
            int k2 = 0;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == ')') k2++;
                if (S[i] == '(') k1++;
                if (k1 == k2)
                {
                    k1 = 0;
                    k2 = 0;
                    if (k1 == 1)
                    {
                        result.Append("()");
                    }
                }
                else if(k1 !=1 || k2 !=0)
                {
                    result.Append(S[i]);
                }
            }
            return result.ToString();
        }
    }
}
