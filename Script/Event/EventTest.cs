using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 事件测试
    /// </summary>
    public class EventTest : MonoBehaviour
    {
        private void Awake()
        {
            //订阅事件
            Main.m_Event.Subscribe<CustomEvent>(OnCustomEvent);
        }

        private void OnDestroy()
        {
            //取消订阅事件
            Main.m_Event.Unsubscribe<CustomEvent>(OnCustomEvent);
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Throw CustomEvent (args)"))
            {
                //抛出事件（带参数）
                Main.m_Event.Throw(Main.m_ReferencePool.Spawn<CustomEvent>().Fill(Random.Range(0, 100)));
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Throw CustomEvent"))
            {
                //抛出事件
                Main.m_Event.Throw<CustomEvent>();
            }
            GUILayout.EndHorizontal();
        }

        private void OnCustomEvent(EventHandlerBase eventHandler)
        {
            if (eventHandler != null)
            {
                Log.Info("接收到CustomEvent事件，参数：" + (eventHandler as CustomEvent).Args);
            }
            else
            {
                Log.Info("接收到CustomEvent事件，无参数。");
            }
        }
    }
}