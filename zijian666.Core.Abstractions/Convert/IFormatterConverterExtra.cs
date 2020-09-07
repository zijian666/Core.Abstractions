using System;
using System.Runtime.Serialization;

namespace zijian666.Core.Abstractions
{
    /// <summary>
    /// 数据转换器扩展接口
    /// </summary>
    public interface IFormatterConverterExtra : IFormatterConverter
    {
        /// <summary>
        /// 尝试转换
        /// </summary>
        bool TryConvert<T>(object value, out T result);

        /// <summary>
        /// 尝试转换
        /// </summary>
        bool TryConvert(object value, Type type, out object result);
    }
}
