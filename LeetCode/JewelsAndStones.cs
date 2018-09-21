using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class JewelsAndStones
    {
        /// <summary>
        /// �����ظ�ֵ���ȶ����ֵ�������J��Ԫ�ز��ظ�����Sѭ���ȶ��ֵ� ʱ�临�Ӷ�O(n)
        /// </summary>
        /// <param name="J"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public int NumJewelsInStones(string J, string S)
        {
            Dictionary<char,char> dic=new Dictionary<char,char>();
            int res = 0;
            foreach (var item in J)
            {
                if(!dic.ContainsKey(item)){
                    dic.Add(item, item);
                }
            }
            foreach (var item in S)
            {
                if (dic.ContainsKey(item))
                {
                    res++;
                }
            }
            return res;
        }
        
    }
    
}