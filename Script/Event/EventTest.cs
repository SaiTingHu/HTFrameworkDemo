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
            //订阅3型事件
            Main.m_Event.Subscribe<CustomEvent>(OnCustomEvent);
        }

        private void OnDestroy()
        {
            //取消订阅3型事件
            Main.m_Event.Unsubscribe<CustomEvent>(OnCustomEvent);
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Throw CustomEvent"))
            {
                //抛出3型事件（订阅的事件类型必须与抛出的事件类型一致）
                Main.m_Event.Throw(Main.m_ReferencePool.Spawn<CustomEvent>().Fill(Random.Range(0, 100)));
            }
            GUILayout.EndHorizontal();
        }

        private void OnCustomEvent(EventHandlerBase eventHandler)
        {
            Log.Info("接收到CustomEvent事件，参数：" + (eventHandler as CustomEvent).Args);
        }
    }
}