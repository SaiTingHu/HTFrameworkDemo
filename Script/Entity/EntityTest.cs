using System.Collections.Generic;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 实体测试
    /// </summary>
    public class EntityTest : MonoBehaviour
    {
        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Create ZhangThree"))
            {
                Vector3 pos = new Vector3(Random.Range(0, 20), Random.Range(0, 20), Random.Range(0, 20));
                Main.m_Entity.CreateEntity<ZhangThree>("张三", null, (player) =>
                {
                    player.Entity.transform.position = pos;
                    Main.m_Controller.SetLookPoint(pos);
                });
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Create LiFour"))
            {
                Vector3 pos = new Vector3(Random.Range(0, 20), Random.Range(0, 20), Random.Range(0, 20));
                Main.m_Entity.CreateEntity<LiFour>("李四", null, (player) =>
                {
                    player.Entity.transform.position = pos;
                    Main.m_Controller.SetLookPoint(pos);
                });
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Kill A ZhangThree"))
            {
                List<ZhangThree> zhangThrees = Main.m_Entity.GetEntities<ZhangThree>();
                if (zhangThrees.Count > 0)
                {
                    Main.m_Entity.DestroyEntity(zhangThrees[0]);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Kill A LiFour"))
            {
                List<LiFour> liFours = Main.m_Entity.GetEntities<LiFour>();
                if (liFours.Count > 0)
                {
                    Main.m_Entity.DestroyEntity(liFours[0]);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("ZhangThree alive Count:" + Main.m_Entity.GetEntities(typeof(ZhangThree)).Count);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("LiFour alive Count:" + Main.m_Entity.GetEntities(typeof(LiFour)).Count);
            GUILayout.EndHorizontal();
        }
    }
}