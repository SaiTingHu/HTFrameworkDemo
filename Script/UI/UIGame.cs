namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建UI逻辑类
    /// </summary>
    [UIResource("ui", "Assets/HTFrameworkDemo/Script/UI/GamePanel.prefab", "ResourcePath")]
    public class UIGame : UILogicResident
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            UIEntity.FindChildren("LogoutButton").rectTransform().AddEventListener(OnLogout);
            UIEntity.FindChildren("BackButton").rectTransform().AddEventListener(OnBack);
        }

        private void OnLogout()
        {
            Close();
            Main.m_UI.OpenResidentUI<UILogin>();
        }

        private void OnBack()
        {
            Close();
            Main.m_UI.OpenResidentUI<UIChoose>();
        }

        /// <summary>
        /// 打开UI
        /// </summary>
        public override void OnOpen(params object[] args)
        {
            base.OnOpen(args);
        }

        /// <summary>
        /// 置顶UI
        /// </summary>
        public override void OnPlaceTop()
        {
            base.OnPlaceTop();
        }

        /// <summary>
        /// 关闭UI
        /// </summary>
        public override void OnClose()
        {
            base.OnClose();
        }

        /// <summary>
        /// 销毁UI
        /// </summary>
        public override void OnDestroy()
        {
            base.OnDestroy();
        }

        /// <summary>
        /// UI逻辑刷新
        /// </summary>
        public override void OnUpdate()
        {
            base.OnUpdate();
        }
    }
}