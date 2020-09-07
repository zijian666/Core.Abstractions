using System;
using System.Runtime.Serialization;

namespace zijian666.Core.Abstractions
{
    /// <summary>
    /// 数据转换扩展接口
    /// </summary>
    public static class IFormatterConverterExtensions
    {
        /// <summary>
        /// 转换对象到指定的类型,如果失败返回默认值
        /// </summary>
        public static T ConvertOrDefault<T>(this IFormatterConverter converter, object value, T defaultValue)
            => TryConvert<T>(converter, value, out var result) ? result : defaultValue;

        /// <summary>
        /// 转换对象到指定的类型,如果失败返回默认值
        /// </summary>
        public static object ConvertOrDefault(this IFormatterConverter converter, object value, Type type, object defaultValue)
            => TryConvert(converter, value, type, out var result) ? result : defaultValue;

        /// <summary>
        /// 转换对象到指定的类型,如果失败返回默认值
        /// </summary>
        public static bool TryConvert<T>(this IFormatterConverter converter, object value, out T result)
        {
            if (converter is IFormatterConverterExtra extra)
            {
                return extra.TryConvert<T>(value, out result);
            }
            try
            {
                result = (T)converter.Convert(value, typeof(T));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// 转换对象到指定的类型,如果失败返回默认值
        /// </summary>
        public static bool TryConvert(this IFormatterConverter converter, object value, Type type, out object result)
        {
            if (converter is IFormatterConverterExtra extra)
            {
                return extra.TryConvert(value, out result);
            }
            try
            {
                result = converter.Convert(value, type);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

    }
}
