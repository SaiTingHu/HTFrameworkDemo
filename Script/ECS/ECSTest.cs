using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// ECS测试
    /// </summary>
    public class ECSTest : MonoBehaviour
    {
        private void Awake()
        {
            Main.m_Controller.SetLookAngle(new Vector3(194.45f, 32.20f, 5.00f));
            Main.m_Controller.SetLookPoint(new Vector3(520.33f, 248.00f, 5.42f));
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("空格键（按住）发出旋转指令！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("回车键（按住）发出缩放指令！");
            GUILayout.EndHorizontal();
        }
    }
}