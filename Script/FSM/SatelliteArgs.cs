using UnityEngine.UI;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 卫星状态机参数
    /// </summary>
    public class SatelliteArgs : FSMArgsBase
    {
        [Label("状态显示框")]
        [DataBinding(nameof(MachineData.State))]
        public InputField StateInputField;
    }
}