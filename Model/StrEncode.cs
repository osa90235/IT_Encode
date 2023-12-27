using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IT_Encode.Interface;

namespace IT_Encode.Model
{
    public class StrEncode : IEncode
    {
        public string GetMd5Hash(string InputStr)
        {
            string EncodeStr = string.Empty;
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(InputStr);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                EncodeStr = sb.ToString();
            }
            return EncodeStr;
        }
    }
}