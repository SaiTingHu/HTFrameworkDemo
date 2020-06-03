using System.Collections.Generic;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 缩放系统（只关注拥有PositionComponent、ScaleComponent组件的实体）
    /// </summary>
    [StarComponent(typeof(PositionComponent), typeof(ScaleComponent))]
    [SystemName("缩放系统")]
    public sealed class ScaleSystem : ECS_System
    {
        int scaleOrder = (int)OrderID.Scale;

        /// <summary>
        /// 系统逻辑更新
        /// </summary>
        /// <param name="entities">系统关注的所有实体</param>
        public override void OnUpdate(HashSet<ECS_Entity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.IsExistOrder(scaleOrder))
                {
                    ScaleComponent component = entity[typeof(ScaleComponent)] as ScaleComponent;
                    entity.transform.localScale += entity.transform.localScale * component.Speed * component.Direction * Time.deltaTime;

                    if (component.Direction == 1)
                    {
                        if (entity.transform.localScale.x >= 1.6) component.Direction = -1;
                    }
                    else
                    {
                        if (entity.transform.localScale.x <= 0.4) component.Direction = 1;
                    }
                }
            }
        }
    }
}