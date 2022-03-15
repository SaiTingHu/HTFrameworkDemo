using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 调试测试组件的调试器UI
    /// </summary>
    [CustomDebugger(typeof(DebugTest))]
    public class DebugerTest : DebuggerComponentBase
    {
        private DebugTest _target;

        public override void OnDebuggerGUI()
        {
            GUILayout.BeginHorizontal();
            _target.Value = GUILayout.HorizontalSlider(_target.Value, 0f, 1f);
            GUILayout.EndHorizontal();

            _target.Value = FloatField("Value", _target.Value);

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Show Value"))
            {
                _target.ShowValue();
            }
            GUILayout.EndHorizontal();
        }

        public override void OnEnable()
        {
            _target = Target as DebugTest;
        }
    }
}