using System.Reflection;

namespace zijian666.Core.Abstractions
{
    /// <summary>
    /// 反射编译器
    /// </summary>
    public interface IReflectCompiler
    {
        /// <summary>
        /// 编译一个构造函数的委托
        /// </summary>
        ObjectCreator<Object> CompileCreator<Object>(ConstructorInfo constructor);
        /// <summary>
        /// 编译属性取值委托
        /// </summary>
        MemberGetter<Value> CompileGetter<Value>(PropertyInfo property);
        /// <summary>
        /// 编译设置属性值的委托
        /// </summary>
        MemberSetter<Value> CompileSetter<Value>(PropertyInfo property);
        /// <summary>
        /// 编译字段取值委托
        /// </summary>
        MemberGetter<Value> CompileGetter<Value>(FieldInfo field);
        /// <summary>
        /// 编译设置字段值的委托
        /// </summary>
        MemberSetter<Value> CompileSetter<Value>(FieldInfo field);
        /// <summary>
        /// 编译执行方法的委托
        /// </summary>
        MethodCaller<Result> CompileCaller<Result>(MethodInfo method);

    }
}
