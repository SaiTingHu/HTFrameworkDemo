using UnityEngine;

namespace HT.Framework.Demo
{
    public class AspectTrackPlayer : MonoBehaviour, IAspectProxyTest
    {
        private AspectProxyTest<IAspectProxyTest> _proxyTest;
        private IAspectProxyTest _proxyer;

        private void Awake()
        {
            _proxyTest = new AspectProxyTest<IAspectProxyTest>(this);
            _proxyer = Main.m_AspectTrack.CreateProxyer(_proxyTest);

            Main.m_AspectTrack.AddInterceptCondition("拦截Track的调用", (method, args) =>
            {
                return method.Name == "Track";
            });
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            Main.m_AspectTrack.IsEnableIntercept = GUILayout.Toggle(Main.m_AspectTrack.IsEnableIntercept, "Intercept");
            GUILayout.Space(10);
            if (GUILayout.Button("Track"))
            {
                _proxyer.Track();
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            _proxyTest.IsDoubleAttackPower = GUILayout.Toggle(_proxyTest.IsDoubleAttackPower, "Double");
            GUILayout.Space(10);
            if (GUILayout.Button("Attack (100 power)"))
            {
                _proxyer.Attack(100);
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            _proxyTest.IsDoubleDefendPower = GUILayout.Toggle(_proxyTest.IsDoubleDefendPower, "Double");
            GUILayout.Space(10);
            if (GUILayout.Button("Defend (50 power)"))
            {
                _proxyer.Defend(50);
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            _proxyTest.IsDoubleRunSpeed = GUILayout.Toggle(_proxyTest.IsDoubleRunSpeed, "Double");
            GUILayout.Space(10);
            if (GUILayout.Button("Run (10 speed)"))
            {
                _proxyer.Run(10);
            }
            GUILayout.EndHorizontal();
        }
        
        public void Track()
        {
            Log.Info("Player Track: " + GetHashCode());
        }

        public int Attack(int power)
        {
            Log.Info("Player Attack: " + power + " Power");
            return power;
        }

        public void Defend(int power)
        {
            Log.Info("Player Defend: " + power + " Power");
        }

        public void Run(int speed)
        {
            Log.Info("Player Run: " + speed + " Speed");
        }
    }
}