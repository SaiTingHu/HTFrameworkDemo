using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 登录流程
    /// </summary>
    public class LoginProcedure : ProcedureBase
    {
        private GameObject _loginPanel;

        /// <summary>
        /// 流程初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            _loginPanel = GameObject.Find("TestUI").FindChildren("LoginPanel");
            _loginPanel.FindChildren("LoginButton").rectTransform().AddEventListener(OnLogin);
        }

        private void OnLogin()
        {
            Main.m_Procedure.SwitchProcedure<ChooseProcedure>();
        }

        /// <summary>
        /// 进入流程
        /// </summary>
        /// <param name="lastProcedure">上一个离开的流程</param>
        public override void OnEnter(ProcedureBase lastProcedure)
        {
            base.OnEnter(lastProcedure);

            _loginPanel.SetActive(true);
        }

        /// <summary>
        /// 离开流程
        /// </summary>
        /// <param name="nextProcedure">下一个进入的流程</param>
        public override void OnLeave(ProcedureBase nextProcedure)
        {
            base.OnLeave(nextProcedure);

            _loginPanel.SetActive(false);
        }
    }
}