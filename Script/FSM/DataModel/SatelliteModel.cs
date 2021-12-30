namespace HT.Framework.Demo
{
    /// <summary>
    /// 卫星数据模型
    /// </summary>
    public class SatelliteModel : DataModelBase
    {
        /// <summary>
        /// 天宫1号机械状态
        /// </summary>
        public BindableString TianGongState = new BindableString();
        /// <summary>
        /// 嫦娥1号机械状态
        /// </summary>
        public BindableString ChangEState = new BindableString();
    }
}