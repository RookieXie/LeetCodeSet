using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            char[] str = s.ToCharArray();
            Stack<char> list = new Stack<char>();
            bool res = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    list.Push(')');
                }
                else if (str[i] == '[')
                {
                    list.Push(']');
                }
                else if (str[i] == '{')
                {
                    list.Push('}');
                }
                else if(list.Count>0&&list.Pop()==str[i])
                {
                   
                }
                else
                {
                    list.Push('f');
                }
            }
            if (list.Count == 0)
            {
                res = true;
            }
            return res;
        }
    }
}
