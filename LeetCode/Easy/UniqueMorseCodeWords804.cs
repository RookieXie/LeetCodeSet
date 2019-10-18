using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /*
     International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

For convenience, the full table for the 26 letters of the English alphabet is given below:

[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter. For example, "cba" can be written as "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-"). We'll call such a concatenation, the transformation of a word.

Return the number of different transformations among all words we have.
         */
    public class UniqueMorseCodeWords804
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="words"></param>
        /// <returns>2019-10-18</returns>
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCodes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            int difNum = 0;
           // HashSet<string> hs = new HashSet<string>();
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string morsecode = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    int wordNum = words[i][j] - 97;
                    morsecode += morseCodes[wordNum];
                }
                //hs.Add(morsecode);
                if (!pairs.ContainsKey(morsecode))
                {
                    pairs.Add(morsecode, 1);
                    difNum++;
                }
                
            }
            return difNum;
        }
        

    }
}
