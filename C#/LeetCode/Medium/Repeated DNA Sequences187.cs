using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * All DNA is composed of a series of nucleotides abbreviated as A, C, G, and T, for example: "ACGAATTCCG". When studying DNA, it is sometimes useful to identify repeated sequences within the DNA.

        Write a function to find all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.

        Example:

        Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"

        Output: ["AAAAACCCCC", "CCCCCAAAAA"]
     * **/
    public class Repeated_DNA_Sequences187
    {
        /// <summary>
        /// 循环处理O(n^2) 优化后O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            List<string> list = new List<string>();
            if (s.Length < 10) return list;

            HashSet<string> vs2 = new HashSet<string>();
            HashSet<string> vs1 = new HashSet<string>();
            for (int i = 0; i < s.Length - 9; i++)
            {
                var si = s.Substring(i, 10);
                if (vs2.Contains(si))
                {
                    if (!vs1.Contains(si))
                    {
                        list.Add(si);
                        vs1.Add(si);
                    }
                }
                else
                {
                    vs2.Add(si);
                }
            }
            return list;

        }
    }
}
