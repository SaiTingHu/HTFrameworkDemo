namespace HT.Framework.Demo
{
    /// <summary>
    /// 卫星状态机数据
    /// </summary>
    public class SatelliteData : FSMDataBase, IDataDriver<MachineData>
    {
        /// <summary>
        /// 数据
        /// </summary>
        public MachineData Data { get; set; }
        public override bool IsAutomate => true;
    }

    /// <summary>
    /// 机械数据
    /// </summary>
    public class MachineData
    {
        /// <summary>
        /// 机械状态
        /// </summary>
        public BindableString State = new BindableString();
    }
}