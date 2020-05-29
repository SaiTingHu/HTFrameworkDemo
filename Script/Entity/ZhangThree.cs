using DG.Tweening;
using UnityEngine;

namespace HT.Framework.Demo
{
    [EntityResource("player", "Assets/HTFrameworkDemo/Script/Entity/Prefab/张三.prefab", "ResourcePath", true)]
    public class ZhangThree : EntityLogicBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            Entity.AddClickListener(() =>
            {
                Entity.transform.DORotate(new Vector3(0, 360, 0), 1, RotateMode.WorldAxisAdd);
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

            Entity.RemoveClickListener();
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