namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建状态
    /// </summary>
    [FiniteStateName("卫星/停机")]
    public class Stop : FiniteStateBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {

        }

        /// <summary>
        /// 进入状态
        /// </summary>
        /// <param name="lastState">上一个离开的状态</param>
        public override void OnEnter(FiniteStateBase lastState)
        {
            (StateMachine.Name + "已停机！").Info();
        }

        /// <summary>
        /// 离开状态
        /// </summary>
        /// <param name="nextState">下一个进入的状态</param>
        public override void OnLeave(FiniteStateBase nextState)
        {

        }

        /// <summary>
        /// 切换状态的动机
        /// </summary>
        public override void OnReason()
        {

        }

        /// <summary>
        /// 状态帧刷新
        /// </summary>
        public override void OnUpdate()
        {

        }

        /// <summary>
        /// 状态终结
        /// </summary>
        public override void OnTermination()
        {

        }
    }
}