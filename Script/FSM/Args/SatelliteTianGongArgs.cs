using UnityEngine.UI;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 天宫卫星状态机参数
    /// </summary>
    public class SatelliteTianGongArgs : FSMArgsBase
    {
        [Label("状态显示框")]
        [DataBinding(typeof(SatelliteModel), "TianGongState")]
        public InputField StateInputField;
    }
}