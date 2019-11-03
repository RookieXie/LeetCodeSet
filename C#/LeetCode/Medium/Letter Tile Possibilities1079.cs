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
        public int NumTilePossibilities(string tiles)
        {
            int length = tiles.Length;
            HashSet<string> vs = new HashSet<string>();
            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(tiles[j]);
                    for (int k = length-j; k >=length; k--)
                    {
                        
                    }

                }
            }
            return 1;

        }
    }
}
