using System;
using System.ComponentModel;
using System.Reflection;

namespace Common.Tools
{
    /// <summary>
    /// 枚举输出信息工具类
    /// </summary>
    public class EnumHelper
    {
        /// <summary>
        /// 读取Description信息工具类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetDescription<T>(T obj)
        {
            //枚举信息
            string objName = obj.ToString();
            //获取枚举类型
            Type t = obj.GetType();
            //根据数据类型，获取该类型字段元属性访问权限
            FieldInfo fi = t.GetField(objName);
            //获取描述信息
            DescriptionAttribute[] arrDesc = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //返回描述信息
            return arrDesc[0].Description;

        }
    }
}
