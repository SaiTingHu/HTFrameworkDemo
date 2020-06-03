using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 缩放组件
    /// </summary>
    [DisallowMultipleComponent]
    [ComponentName("缩放组件")]
    public sealed class ScaleComponent : ECS_Component
    {
        /// <summary>
        /// 缩放速度
        /// </summary>
        public float Speed = 1;
        /// <summary>
        /// 缩放方向
        /// </summary>
        public int Direction { get; set; } = -1;
    }
}