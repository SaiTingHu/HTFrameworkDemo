using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 选择流程
    /// </summary>
    public class ChooseProcedure : ProcedureBase
    {
        private GameObject _choosePanel;

        /// <summary>
        /// 流程初始化
        /// </summary>
        public override void OnInit()
        {
            _choosePanel = GameObject.Find("UI").FindChildren("ChoosePanel");
            _choosePanel.FindChildren("Role1Button").rectTransform().AddEventListener(OnChooseRole);
            _choosePanel.FindChildren("Role2Button").rectTransform().AddEventListener(OnChooseRole);
        }

        private void OnChooseRole()
        {
            Main.m_Procedure.SwitchProcedure<GameProcedure>();
        }

        /// <summary>
        /// 进入流程
        /// </summary>
        /// <param name="lastProcedure">上一个离开的流程</param>
        public override void OnEnter(ProcedureBase lastProcedure)
        {
            _choosePanel.SetActive(true);
        }

        /// <summary>
        /// 离开流程
        /// </summary>
        /// <param name="nextProcedure">下一个进入的流程</param>
        public override void OnLeave(ProcedureBase nextProcedure)
        {
            _choosePanel.SetActive(false);
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