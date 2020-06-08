using System.Collections.Generic;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 旋转系统（只关注拥有PositionComponent、RotateComponent组件的实体）
    /// </summary>
    [StarComponent(typeof(PositionComponent), typeof(RotateComponent))]
    [SystemName("旋转系统")]
    public sealed class RotateSystem : ECS_System
    {
        int rotateOrder = (int)OrderID.Rotate;

        /// <summary>
        /// 系统逻辑更新
        /// </summary>
        /// <param name="entities">系统关注的所有实体</param>
        public override void OnUpdate(HashSet<ECS_Entity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.IsExistOrder(rotateOrder))
                {
                    RotateComponent component = entity.Component<RotateComponent>();
                    entity.transform.Rotate(component.Axle, component.Speed);
                }
            }
        }
    }
}