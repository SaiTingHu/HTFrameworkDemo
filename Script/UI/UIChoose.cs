namespace HT.Framework.Demo
{
    /// <summary>
    /// 新建UI逻辑类
    /// </summary>
    [UIResource("ui", "Assets/HTFrameworkDemo/Script/UI/ChoosePanel.prefab", "ResourcePath")]
    public class UIChoose : UILogicResident
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            UIEntity.FindChildren("Role1Button").rectTransform().AddEventListener(OnChooseRole);
            UIEntity.FindChildren("Role2Button").rectTransform().AddEventListener(OnChooseRole);
        }

        private void OnChooseRole()
        {
            Close();
            Main.m_UI.OpenUI<UIGame>();
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