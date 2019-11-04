using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /**
     * You have a set of tiles, where each tile has one letter tiles[i] printed on it.  Return the number of possible non-empty sequences of letters you can make.

 

        Example 1:

        Input: "AAB"
        Output: 8
        Explanation: The possible sequences are "A", "B", "AA", "AB", "BA", "AAB", "ABA", "BAA".
        Example 2:

        Input: "AAABBC"
        Output: 188
 

        Note:

        1 <= tiles.length <= 7
        tiles consists of uppercase English letters.
     * **/
    public class Letter_Tile_Possibilities1079
    {
        /// <summary>
        /// 思路： 使用dictionary 记住最终字符和组合的索引，
        /// 从一个字符开始，进行循环，记住前一轮组合的字符，然后与当期循环的字符拼接 判断
        /// </summary>
        /// <param name="tiles"></param>
        /// <returns></returns>
        public int NumTilePossibilities(string tiles)
        {
            var n = tiles.Length;
            HashSet<string> hs = new HashSet<string>();
            for (int i = 1; i <= n; i++)
            {
                int k = i;

                Dictionary<string, List<int>> nums = new Dictionary<string, List<int>>();

                Dictionary<string, List<int>> tNums = new Dictionary<string, List<int>>();
                while (k > 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (nums.Count > 0)
                        {
                            foreach (var item in nums)
                            {
                                if (!item.Value.Contains(j))
                                {
                                    if (!tNums.ContainsKey(item.Key + tiles[j]))
                                    {
                                        var list = new List<int>();
                                        list.AddRange(item.Value);
                                        list.Add(j);
                                        tNums.Add(item.Key + tiles[j], list);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (!tNums.ContainsKey(tiles[j].ToString()))
                            {
                                tNums.Add(tiles[j].ToString(), new List<int> { j });
                            }
                        }
                    }
                    if (k == 1)
                    {
                        foreach (var item in tNums)
                        {
                            hs.Add(item.Key);
                        }
                    }
                    else
                    {
                        nums.Clear();
                        foreach (var item in tNums)
                        {
                            nums.Add(item.Key, item.Value);
                        }
                    }
                    tNums.Clear();
                    k--;
                }

            }
            return hs.Count;
        }


        /**Thoughts

        input: AAB
        count: A -> 2, B -> 1

        For sequence of length 1:

        We can pick either A, or B.
        So we have "A", "B".
        For sequence of length 2:

        We build it based on "sequence of length 1"
        For "A":
        count: A -> 1, B -> 1
        We can still pick either A, or B
        So we have "AA", "AB"
        For "B":
        count: A -> 2, B -> 0
        We can only pick A
        So we have "BA"
        For sequence of length 3: blablabla

        Implementation

        We don't need to keep track of the sequence. We only need count
        If we implement the above idea by each level (Count all sequence of length 1, then count all sequence of length 2, etc), we have to remember previous sequence.
        So we use recursion instead. Just remember to add the count back (arr[i]++).

         * **/
        public int NumTilePossibilities2(string tiles)
        {
            int[] count = new int[26];
            for (int i = 0; i < tiles.Length; i++)
            {
                count[tiles[i] - 'A']++;
            }
            return DFS(count);
        }
        public int DFS(int[] count)
        {
            int sum = 0;
            for (int i = 0; i < 26; i++)
            {
                if (count[i] == 0) continue;
                count[i]--;
                sum++;
                sum += DFS(count);
                count[i]++;
            }
            return sum;
        }
    }
}
