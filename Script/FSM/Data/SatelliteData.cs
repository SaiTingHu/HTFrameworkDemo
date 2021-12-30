namespace HT.Framework.Demo
{
    /// <summary>
    /// 卫星状态机数据
    /// </summary>
    public class SatelliteData : FSMDataBase, IDataDriver
    {
        public override bool IsAutomate => true;
    }
}