namespace zijian666.Core.Abstractions
{
    /// <summary>
    /// 功能插槽
    /// </summary>
    /// <typeparam name="Feature"></typeparam>
    public interface ISlot<Feature>
    {
        void Set(Feature feature);
    }
}
