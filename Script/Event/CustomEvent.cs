namespace HT.Framework.Demo
{
    /// <summary>
    /// 自定义事件
    /// </summary>
    public class CustomEvent : EventHandlerBase
    {
        public int Args;

        /// <summary>
        /// 填充数据，所有属性、字段的初始化工作可以在这里完成
        /// </summary>
        public CustomEvent Fill(int args)
        {
            Args = args;
            return this;
        }

        /// <summary>
        /// 重置引用，当被引用池回收时调用
        /// </summary>
        public override void Reset()
        {

        }
    }
}