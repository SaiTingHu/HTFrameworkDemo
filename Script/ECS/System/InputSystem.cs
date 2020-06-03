using System.Collections.Generic;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 输入系统（只关注拥有InputComponent组件的实体）
    /// </summary>
    [StarComponent(typeof(InputComponent))]
    [SystemName("输入系统")]
    public sealed class InputSystem : ECS_System
    {
        /// <summary>
        /// 系统逻辑更新
        /// </summary>
        /// <param name="entities">系统关注的所有实体</param>
        public override void OnUpdate(HashSet<ECS_Entity> entities)
        {
            //空格键发出旋转指令
            if (Main.m_Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var entity in entities)
                {
                    entity.GiveOrder((int)OrderID.Rotate);
                }
            }
            if (Main.m_Input.GetKeyUp(KeyCode.Space))
            {
                foreach (var entity in entities)
                {
                    entity.RecedeOrder((int)OrderID.Rotate);
                }
            }

            //回车键发出缩放指令
            if (Main.m_Input.GetKeyDown(KeyCode.Return))
            {
                foreach (var entity in entities)
                {
                    entity.GiveOrder((int)OrderID.Scale);
                }
            }
            if (Main.m_Input.GetKeyUp(KeyCode.Return))
            {
                foreach (var entity in entities)
                {
                    entity.RecedeOrder((int)OrderID.Scale);
                }
            }
        }
    }
}