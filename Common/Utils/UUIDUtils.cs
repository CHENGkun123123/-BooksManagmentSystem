using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils
{
    /// <summary>
    /// ID生成工具类
    /// </summary>
    public class UUIDUtils
    {
        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns></returns>
        public static int UUIDRandom()
        {
            return (int)new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}
