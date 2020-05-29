using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 有限状态机测试
    /// </summary>
    public class FSMTest : MonoBehaviour
    {
        private FSM _one;
        private FSM _two;

        private void Awake()
        {
            _one = Main.m_FSM.GetFSMByName("天宫1号");
            _two = Main.m_FSM.GetFSMByName("嫦娥1号");
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("天宫1号");
            GUI.enabled = !(_one.CurrentState is Idle);
            if (GUILayout.Button("待机"))
            {
                _one.SwitchState<Idle>();
            }
            GUI.enabled = _one.CurrentState is Idle;
            if (GUILayout.Button("运转"))
            {
                _one.SwitchState<Run>();
            }
            GUI.enabled = _one.CurrentState is Idle;
            if (GUILayout.Button("停机"))
            {
                _one.SwitchState<Stop>();
            }
            GUI.enabled = true;
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("嫦娥1号");
            GUI.enabled = !(_two.CurrentState is Idle);
            if (GUILayout.Button("待机"))
            {
                _two.SwitchState<Idle>();
            }
            GUI.enabled = _two.CurrentState is Idle;
            if (GUILayout.Button("运转"))
            {
                _two.SwitchState<Run>();
            }
            GUI.enabled = _two.CurrentState is Idle;
            if (GUILayout.Button("停机"))
            {
                _two.SwitchState<Stop>();
            }
            GUI.enabled = true;
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("启动所有卫星"))
            {
                Main.m_FSM.RenewalOfGroup("卫星");
            }
            if (GUILayout.Button("全部卫星宕机"))
            {
                Main.m_FSM.FinalOfGroup("卫星");
            }
            GUILayout.EndHorizontal();
        }
    }
}