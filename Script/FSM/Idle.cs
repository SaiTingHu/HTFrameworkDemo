namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建状态
    /// </summary>
    [FiniteStateName("卫星/待机")]
    public class Idle : FiniteStateBase
    {
        private SatelliteData _data;

        public override void OnInit()
        {
            base.OnInit();

            _data = StateMachine.CurrentData.Cast<SatelliteData>();
        }

        /// <summary>
        /// 进入状态
        /// </summary>
        /// <param name="lastState">上一个离开的状态</param>
        public override void OnEnter(FiniteStateBase lastState)
        {
            base.OnEnter(lastState);

            (StateMachine.Name + "进入待机模式！").Info();

            _data.Data.State.Value = StateMachine.Name + "-待机模式";
        }

        /// <summary>
        /// 离开状态
        /// </summary>
        /// <param name="nextState">下一个进入的状态</param>
        public override void OnLeave(FiniteStateBase nextState)
        {
            base.OnLeave(nextState);

            (StateMachine.Name + "退出待机模式！").Info();
        }
    }
}