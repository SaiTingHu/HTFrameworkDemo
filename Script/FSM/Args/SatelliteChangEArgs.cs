using UnityEngine.UI;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 嫦娥卫星状态机参数
    /// </summary>
    public class SatelliteChangEArgs : FSMArgsBase
    {
        [Label("状态显示框")]
        [DataBinding(typeof(SatelliteModel), "ChangEState")]
        public InputField StateInputField;
    }
}