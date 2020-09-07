namespace zijian666.Core.Abstractions
{
    /// <summary>
    /// 属性或字段的取值方法的委托
    /// </summary>
    public delegate Value MemberGetter<Value>(object instance);
    /// <summary>
    /// 属性或者字段的设置方法的委托
    /// </summary>
    public delegate void MemberSetter<Value>(object instance, Value value);
    /// <summary>
    /// 执行指定方法的委托
    /// </summary>
    public delegate Result MethodCaller<Result>(object instance, params object[] args);
    /// <summary>
    /// 对象构造函数的委托
    /// </summary>
    public delegate Object ObjectCreator<Object>(params object[] args);
}
