namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建状态
    /// </summary>
    [FiniteStateName("卫星/运行")]
    public class Run : FiniteStateBase
    {
        /// <summary>
        /// 进入状态
        /// </summary>
        /// <param name="lastState">上一个离开的状态</param>
        public override void OnEnter(FiniteStateBase lastState)
        {
            base.OnEnter(lastState);

            (StateMachine.Name + "进入运转模式！").Info();
        }

        /// <summary>
        /// 离开状态
        /// </summary>
        /// <param name="nextState">下一个进入的状态</param>
        public override void OnLeave(FiniteStateBase nextState)
        {
            base.OnEnter(nextState);

            (StateMachine.Name + "退出运转模式！").Info();
        }

        /// <summary>
        /// 状态帧刷新
        /// </summary>
        public override void OnUpdate()
        {
            base.OnUpdate();

            (StateMachine.Name + "运转中！").Info();
        }
    }
}