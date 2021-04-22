using System.Text;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 调试测试
    /// </summary>
    public class DebugTest : MonoBehaviour
    {
        public float Value = 0.5f;

        private void Start()
        {
            //监控方法调用
            MonitorData data = Main.m_Debug.MonitorExecute(StringConcat1, "使用+号累加字符串1千次");
            Log.Info(data.ToString());
            
            //监控方法调用
            data = Main.m_Debug.MonitorExecute(StringConcat2, "使用StringBuilder累加字符串1千次");
            Log.Info(data.ToString());

            //开始监控
            Main.m_Debug.BeginMonitor("字符串两两相连1千次");

            StringConcat3();

            //结束监控
            data = Main.m_Debug.EndMonitor();
            Log.Info(data.ToString());
        }

        public void ShowValue()
        {
            Log.Info("当前的值为：" + Value);
        }

        private void StringConcat1()
        {
            string str = "";
            for (int i = 0; i < 1000; i++)
            {
                str += "string";
            }
        }

        private void StringConcat2()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                builder.Append("string");
            }
            string str = builder.ToString();
        }

        private void StringConcat3()
        {
            string str = "";
            for (int i = 0; i < 1000; i++)
            {
                str = "string" + i;
            }
        }
    }
}