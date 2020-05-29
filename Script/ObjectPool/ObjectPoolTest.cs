using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 对象池测试
    /// </summary>
    public class ObjectPoolTest : MonoBehaviour
    {
        public GameObject Panel;
        public GameObject CubeTem;
        public GameObject SphereTem;

        private Vector3 _hitPoint;

        private void Awake()
        {
            Main.m_ObjectPool.RegisterSpawnPool("Cube", CubeTem, OnCubeSpawn, OnCubeDespawn);
            Main.m_ObjectPool.RegisterSpawnPool("Sphere", SphereTem, OnSphereSpawn, OnSphereDespawn);
        }

        private void Update()
        {
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseLeftDoubleClick))
            {
                if (Main.m_Controller.RayTargetObj == Panel)
                {
                    _hitPoint = Main.m_Controller.RayHitPoint;
                    Main.m_ObjectPool.Spawn("Cube");
                }
            }
            if (Main.m_Input.GetButtonDown(InputButtonType.MouseMiddle))
            {
                if (Main.m_Controller.RayTargetObj == Panel)
                {
                    _hitPoint = Main.m_Controller.RayHitPoint;
                    Main.m_ObjectPool.Spawn("Sphere");
                }
            }
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("双击鼠标左键，在点击位置创建一个Cube！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("单击鼠标中键，在点击位置创建一个Sphere！");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("鼠标左键点击任意物体，回收他！");
            GUILayout.EndHorizontal();
        }

        private void OnDestroy()
        {
            Main.m_ObjectPool.UnRegisterSpawnPool("Cube");
            Main.m_ObjectPool.UnRegisterSpawnPool("Sphere");
        }

        private void OnCubeSpawn(GameObject obj)
        {
            obj.transform.position = _hitPoint + new Vector3(0, 1, 0);
            obj.AddClickListener(() =>
            {
                Main.m_ObjectPool.Despawn("Cube", obj);
            });
        }

        private void OnCubeDespawn(GameObject obj)
        {
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            obj.RemoveClickListener();
        }

        private void OnSphereSpawn(GameObject obj)
        {
            obj.transform.position = _hitPoint + new Vector3(0, 1, 0);
            obj.AddClickListener(() =>
            {
                Main.m_ObjectPool.Despawn("Sphere", obj);
            });
        }

        private void OnSphereDespawn(GameObject obj)
        {
            obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
            obj.RemoveClickListener();
        }
    }
}