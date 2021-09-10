using DG.Tweening;

namespace HT.Framework.Demo
{
    [EntityResource("player", "Assets/HTFrameworkDemo/Script/Entity/Prefab/李四.prefab", "ResourcePath")]
    public class LiFour : EntityLogicBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            Entity.AddClickListener(() =>
            {
                Entity.transform.DOShakeScale(1);
            });
        }

        /// <summary>
        /// 显示实体
        /// </summary>
        public override void OnShow()
        {
            base.OnShow();
        }

        /// <summary>
        /// 隐藏实体
        /// </summary>
        public override void OnHide()
        {
            base.OnHide();
        }

        /// <summary>
        /// 销毁实体
        /// </summary>
        public override void OnDestroy()
        {
            base.OnDestroy();

            Entity.RemoveAllClickListener();
        }

        /// <summary>
        /// 实体逻辑刷新
        /// </summary>
        public override void OnUpdate()
        {
            base.OnUpdate();
        }

        /// <summary>
        /// 重置实体
        /// </summary>
        public override void Reset()
        {
            base.Reset();
        }
    }
}