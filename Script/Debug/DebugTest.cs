using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 调试测试
    /// </summary>
    public class DebugTest : MonoBehaviour
    {
        public float Value = 0.5f;

        public void ShowValue()
        {
            Log.Info("当前的值为：" + Value);
        }
    }
}