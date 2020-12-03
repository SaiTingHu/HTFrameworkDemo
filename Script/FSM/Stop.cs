namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建状态
    /// </summary>
    [FiniteStateName("卫星/停机")]
    public class Stop : FiniteStateBase
    {
        /// <summary>
        /// 进入状态
        /// </summary>
        /// <param name="lastState">上一个离开的状态</param>
        public override void OnEnter(FiniteStateBase lastState)
        {
            base.OnEnter(lastState);

            (StateMachine.Name + "已停机！").Info();
        }
    }
}