namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建流程
    /// </summary>
    public class UITestProcedure : ProcedureBase
    {
        /// <summary>
        /// 流程初始化
        /// </summary>
        public override void OnInit()
        {

        }

        /// <summary>
        /// 进入流程
        /// </summary>
        /// <param name="lastProcedure">上一个离开的流程</param>
        public override void OnEnter(ProcedureBase lastProcedure)
        {
            Main.m_UI.OpenResidentUI<UILogin>();
        }

        /// <summary>
        /// 离开流程
        /// </summary>
        /// <param name="nextProcedure">下一个进入的流程</param>
        public override void OnLeave(ProcedureBase nextProcedure)
        {

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