using System;

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
