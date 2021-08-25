namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建流程
    /// </summary>
    public class UITestProcedure : ProcedureBase
    {
        /// <summary>
        /// 进入流程
        /// </summary>
        /// <param name="lastProcedure">上一个离开的流程</param>
        public override void OnEnter(ProcedureBase lastProcedure)
        {
            base.OnEnter(lastProcedure);

            Main.m_UI.OpenUI<UILogin>();
        }
    }
}