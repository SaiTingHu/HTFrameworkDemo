namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建UI逻辑类
    /// </summary>
    [UIResource("ui", "Assets/HTFrameworkDemo/Script/UI/LoginPanel.prefab", "ResourcePath")]
    public class UILogin : UILogicResident
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            UIEntity.FindChildren("LoginButton").rectTransform().AddEventListener(OnLogin);
        }

        private void OnLogin()
        {
            Close();
            Main.m_UI.OpenUI<UIChoose>();
        }

        /// <summary>
        /// 打开UI
        /// </summary>
        public override void OnOpen(params object[] args)
        {
            base.OnOpen(args);
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