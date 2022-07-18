using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Common.Tools
{
    public class MD5Tool
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="cleartext">需要加密的字符串</param>
        /// <returns>MD5加密结果</returns>
        public static string EncryptByMD5(string cleartext)
        {

            var md5 = MD5.Create();
            var bs = md5.ComputeHash(Encoding.UTF8.GetBytes(cleartext));
            var sb = new StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2"));
            }
            //所有字符转为大写
            return sb.ToString().ToUpper();

        }
    }
}
