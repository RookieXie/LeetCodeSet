using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * Given an array of strings, group anagrams together.

    Example:

    Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    Output:
    [
      ["ate","eat","tea"],
      ["nat","tan"],
      ["bat"]
    ]
    Note:

    All inputs will be in lowercase.
    The order of your output does not matter.
     * **/
    public class Group_Anagrams49
    {
        /// <summary>
        /// 字符排序之后再进行比较
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> lists = new List<IList<string>>();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            
            foreach (var item in strs)
            {
                char[] all = new char[item.Length];
                for (int i = 0; i < item.Length; i++)
                {
                    all[i]=item[i];
                }
                Array.Sort(all);
                StringBuilder sb = new StringBuilder();
                foreach (var ch in all)
                {
                    sb.Append(ch);
                }
                var key = sb.ToString();
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(item);
                }
                else
                {
                    dic.Add(key, new List<string> { item });
                }
            }
            foreach (var item in dic)
            {
                lists.Add(item.Value);
            }
            return lists;
        }
    }
}
