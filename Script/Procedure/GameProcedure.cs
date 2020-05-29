using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 游戏流程
    /// </summary>
    public class GameProcedure : ProcedureBase
    {
        private GameObject _gamePanel;

        /// <summary>
        /// 流程初始化
        /// </summary>
        public override void OnInit()
        {
            _gamePanel = GameObject.Find("UI").FindChildren("GamePanel");
            _gamePanel.FindChildren("LogoutButton").rectTransform().AddEventListener(OnLogout);
            _gamePanel.FindChildren("BackButton").rectTransform().AddEventListener(OnBack);
        }

        private void OnBack()
        {
            Main.m_Procedure.SwitchProcedure<ChooseProcedure>();
        }

        private void OnLogout()
        {
            Main.m_Procedure.SwitchProcedure<LoginProcedure>();
        }

        /// <summary>
        /// 进入流程
        /// </summary>
        /// <param name="lastProcedure">上一个离开的流程</param>
        public override void OnEnter(ProcedureBase lastProcedure)
        {
            _gamePanel.SetActive(true);
        }

        /// <summary>
        /// 离开流程
        /// </summary>
        /// <param name="nextProcedure">下一个进入的流程</param>
        public override void OnLeave(ProcedureBase nextProcedure)
        {
            _gamePanel.SetActive(false);
        }

        /// <summary>
        /// 流程帧刷新
        /// </summary>
        public override void OnUpdate()
        {

        }

        /// <summary>
        /// 流程帧刷新（秒）
        /// </summary>
        public override void OnUpdateSecond()
        {

        }
    }
}