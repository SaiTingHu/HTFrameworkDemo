namespace HT.Framework.Demo
{
    /// <summary>
    /// UI数据驱动测试模型
    /// </summary>
    public class UIDBUserModel : DataModelBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public BindableString Name = new BindableString();
        /// <summary>
        /// 年龄
        /// </summary>
        public BindableInt Age = new BindableInt();
        /// <summary>
        /// 力量
        /// </summary>
        public BindableFloat Power = new BindableFloat();
        /// <summary>
        /// 是否是神级角色
        /// </summary>
        public BindableBool IsGod = new BindableBool();
        /// <summary>
        /// 种族
        /// </summary>
        public BindableSelectable Race = new BindableSelectable(new string[] { "人族", "魔族", "神族", "龙族" });
    }
}