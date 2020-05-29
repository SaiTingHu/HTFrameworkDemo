using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 自定义模块测试
    /// </summary>
    public class CustomModuleTest : MonoBehaviour
    {
        private CustomModuleBase _timeModule;

        private void Start()
        {
            _timeModule = Main.m_CustomModule["时间模块"];
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("时间模块：");
            bool value = GUILayout.Toggle(_timeModule.IsRunning, "启用");
            if (value != _timeModule.IsRunning)
            {
                _timeModule.IsRunning = value;
            }
            GUILayout.EndHorizontal();
        }
    }
}