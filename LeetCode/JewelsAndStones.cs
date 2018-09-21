using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class JewelsAndStones
    {
        /// <summary>
        /// 查找重复值，先定义字典来放置J中元素不重复，在S循环比对字典 时间复杂度O(n)
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