using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 旋转组件
    /// </summary>
    [DisallowMultipleComponent]
    [ComponentName("旋转组件")]
    public sealed class RotateComponent : ECS_Component
    {
        /// <summary>
        /// 旋转轴
        /// </summary>
        public Vector3 Axle = new Vector3(0, 1, 0);
        /// <summary>
        /// 旋转速度
        /// </summary>
        public float Speed = 1;
    }
}