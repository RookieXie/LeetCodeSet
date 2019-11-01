using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode.Md5
{
    public class MD5Helper
    {
        public static string GetMd5(string input)
        {


            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5Hasher.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
                // To force the hex string to lower-case letters instead of
                // upper-case, use he following line instead:
                // sb.Append(hashBytes[i].ToString("x2")); 
            }
            return sb.ToString();
        }
    }
}
