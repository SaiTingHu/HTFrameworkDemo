using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 输入测试
    /// </summary>
    public class InputTest : MonoBehaviour
    {
        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            Main.m_Input.IsEnableInputDevice = GUILayout.Toggle(Main.m_Input.IsEnableInputDevice, "启用输入");
            GUILayout.EndHorizontal();
        }

        private void Update()
        {
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseLeft))
            {
                Log.Info("鼠标左键按下！");
            }
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseRight))
            {
                Log.Info("鼠标右键按下！");
            }
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseMiddle))
            {
                Log.Info("鼠标中键按下！");
            }
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseLeftDoubleClick))
            {
                Log.Info("鼠标左键双击！");
            }
            if (!Main.m_Input.GetAxisRaw(InputAxisType.Horizontal).Approximately(0))
            {
                Log.Info("水平轴线输入中！");
            }
            if (!Main.m_Input.GetAxisRaw(InputAxisType.Vertical).Approximately(0))
            {
                Log.Info("垂直轴线输入中！");
            }
            if (!Main.m_Input.GetAxisRaw(InputAxisType.UpperLower).Approximately(0))
            {
                Log.Info("上下轴线输入中！");
            }
            if (!Main.m_Input.GetAxisRaw(InputAxisType.MouseScrollWheel).Approximately(0))
            {
                Log.Info("鼠标滚轮输入中！");
            }

            if (Main.m_Input.GetKeyDown(KeyCode.Space))
            {
                Log.Info("键盘空格按下！");
            }
            if (Main.m_Input.GetKeyDown(KeyCode.V, KeyCode.B))
            {
                Log.Info("组合键：V + B 按下！");
            }
            if (Main.m_Input.GetKeyDown(KeyCode.H, KeyCode.N, KeyCode.M))
            {
                Log.Info("组合键：H + N + M 按下！");
            }
        }
    }
}