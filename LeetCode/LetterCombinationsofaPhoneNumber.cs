using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LetterCombinationsofaPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            string[] letters = new string[] { "","", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            List<string> temp = new List<string>();
            for (int i = 0; i < digits.Length; i++)
            {
                int t =Convert.ToInt32(digits[i].ToString());
                temp.Add(letters[t]);
            }
            List<string> res = new List<string>();
            if (digits.Length == 0) { return res; }
            if (digits.Length == 1)
            {
                for (int i = 0; i < temp[0].Length; i++)
                {
                    res.Add(temp[0][i].ToString());
                }
                return res;
            }
            res= ConvertToString(temp, 0);
            return res;
        }

        public List<string> ConvertToString(List<string> laterStr, int mid)
        {
            List<string> res = new List<string>();
            if (laterStr.Count - mid > 2)
            {
                res = ConvertToString(laterStr, mid + 1);
            }
            else
            {
                for (int i = 0; i < laterStr[mid].Length; i++)
                {
                    for (int j = 0; j < laterStr[mid+1].Length; j++)
                    {
                        res.Add(laterStr[mid][i].ToString() + laterStr[mid + 1][j]);
                    }
                }
                return res;
            }
            List<string> resT = new List<string>();
            for (int j = 0; j < res.Count; j++)
            {
                for (int i = 0; i < laterStr[mid].Length; i++)
                {
                    resT.Add(laterStr[mid][i] + res[j]);
                }
            }
            return resT;
        }
    }
}
