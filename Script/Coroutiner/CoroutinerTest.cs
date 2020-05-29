using System.Collections;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 协程调度器测试
    /// </summary>
    public class CoroutinerTest : MonoBehaviour
    {
        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("启动一个 Coroutine1"))
            {
                Main.m_Coroutiner.Run(Coroutine1);
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("启动一个 Coroutine2"))
            {
                Main.m_Coroutiner.Run(Coroutine2);
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("启动一个 Coroutine3"))
            {
                Main.m_Coroutiner.Run(Coroutine3);
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("启动一个 Coroutine4(鸿蒙)"))
            {
                Main.m_Coroutiner.Run(Coroutine4, "鸿蒙");
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("启动一个 Coroutine4(麒麟)"))
            {
                Main.m_Coroutiner.Run(Coroutine4, "麒麟");
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("提示：请打开协程调试器面板，路径：HTFramework/Coroutiner。");
            GUILayout.EndHorizontal();
        }

        IEnumerator Coroutine1()
        {
            yield return YieldInstructioner.GetWaitForEndOfFrame();
            Debug.Log("协程 Coroutine1 执行！");
        }

        IEnumerator Coroutine2()
        {
            yield return YieldInstructioner.GetWaitForEndOfFrame();
            Debug.Log("协程 Coroutine2 执行！");
        }

        IEnumerator Coroutine3()
        {
            while (true)
            {
                yield return YieldInstructioner.GetWaitForSeconds(1);
                Debug.Log("协程 Coroutine3 执行！");
            }
        }

        IEnumerator Coroutine4(string value)
        {
            yield return YieldInstructioner.GetWaitForEndOfFrame();
            Debug.Log("协程 Coroutine4 执行！参数：" + value);
        }
    }
}