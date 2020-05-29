using System.Reflection;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 测试切面代理者
    /// </summary>
    public class AspectProxyTest<T> : AspectProxyBase<T> where T : IAspectProxyTest
    {
        public bool IsDoubleAttackPower = false;
        public bool IsDoubleDefendPower = false;
        public bool IsDoubleRunSpeed = false;

        public AspectProxyTest(T realObject) : base(realObject) { }

        protected override object[] OnBeforeInvoke(MethodBase method, object[] args)
        {
            bool isHaveIntArgs = args.Length > 0 && args[0] is int;
            if (isHaveIntArgs)
            {
                int oldArgs = (int)args[0];
                int newArgs = oldArgs;
                bool isDouble = false;
                switch (method.Name)
                {
                    case "Attack":
                        isDouble = IsDoubleAttackPower;
                        break;
                    case "Defend":
                        isDouble = IsDoubleDefendPower;
                        break;
                    case "Run":
                        isDouble = IsDoubleRunSpeed;
                        break;
                }
                if (isDouble)
                {
                    newArgs *= 2;
                }
                Log.Info(string.Format("【BeforeInvoke】{0} - oldArgs: {1} - newArgs: {2}", method.Name, oldArgs, newArgs));
                args[0] = newArgs;
                return args;
            }
            else
            {
                Log.Info(string.Format("【BeforeInvoke】{0} - oldArgs: {1} - newArgs: {2}", method.Name, "null", "null"));
                return args;
            }
        }

        protected override void OnAfterInvoke(MethodBase method, object returnValue)
        {
            Log.Info(string.Format("【AfterInvoke】{0} - returnValue: {1}", method.Name, returnValue != null ? returnValue.ToString() : "null"));
        }
    }

    public interface IAspectProxyTest : IAspectTrackObject
    {
        int Attack(int power);
        void Defend(int power);
        void Run(int speed);
    }
}