using System.Collections.Generic;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 引用池测试
    /// </summary>
    public class RPoolTest : MonoBehaviour
    {
        private List<Cube> _cubes = new List<Cube>();
        private List<Sphere> _spheres = new List<Sphere>();

        private void Update()
        {
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseLeft))
            {
                Cube cube = Main.m_ReferencePool.Spawn<Cube>();
                Log.Info("一个 Cube 被创建！ HashCode：" + cube.GetHashCode());
                _cubes.Add(cube);
            }
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseRight))
            {
                Sphere sphere = Main.m_ReferencePool.Spawn<Sphere>();
                Log.Info("一个 Sphere 被创建！ HashCode：" + sphere.GetHashCode());
                _spheres.Add(sphere);
            }
            if (Main.m_Input.GetKeyDown(KeyCode.Space, KeyCode.Alpha1))
            {
                if (_cubes.Count > 0)
                {
                    Cube cube = _cubes[0];
                    _cubes.RemoveAt(0);
                    Main.m_ReferencePool.Despawn(cube);
                }
            }
            if (Main.m_Input.GetKeyDown(KeyCode.Space, KeyCode.Alpha2))
            {
                if (_spheres.Count > 0)
                {
                    Sphere sphere = _spheres[0];
                    _spheres.RemoveAt(0);
                    Main.m_ReferencePool.Despawn(sphere);
                }
            }
            if (Main.m_Input.GetKeyDown(KeyCode.Space, KeyCode.Alpha3))
            {
                Main.m_ReferencePool.Despawns(_cubes);
                Main.m_ReferencePool.Despawns(_spheres);
            }
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("Cube Count:" + _cubes.Count);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("Sphere Count:" + _spheres.Count);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("单击鼠标左键，新建一个Cube！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("单击鼠标右键，新建一个Sphere！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("按下空格键 + 1，回收一个Cube！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("按下空格键 + 2，回收一个Sphere！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box");
            GUILayout.Label("按下空格键 + 3，回收所有对象！");
            GUILayout.EndHorizontal();
        }
    }
}