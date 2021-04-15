using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 资源测试
    /// </summary>
    public class ResourceTest : MonoBehaviour
    {
        private PrefabInfo _cube = new PrefabInfo("cube", "Assets/HTFrameworkDemo/Script/Resource/Cube.prefab", null);
        private PrefabInfo _capsule = new PrefabInfo("capsule", "Assets/HTFrameworkDemo/Script/Resource/Capsule.prefab", null);
        private PrefabInfo _sphere = new PrefabInfo("sphere", "Assets/HTFrameworkDemo/Script/Resource/Sphere.prefab", null);

        private void Awake()
        {
            Main.m_Resource.SetAssetBundlePath(Application.dataPath + "/HTFrameworkDemo/Script/Resource/AB/");
        }

        private void Start()
        {
            //加载三个预制体，他们关联的AB包会被自动加载
            Main.m_Resource.LoadPrefab(_cube, null, OnLoading, OnLoadDone);
            Main.m_Resource.LoadPrefab(_capsule, null, OnLoading, OnLoadDone);
            Main.m_Resource.LoadPrefab(_sphere, null, OnLoading, OnLoadDone);
        }

        private void OnLoadDone(GameObject arg)
        {
            Log.Info("加载完成：" + arg.name);
            arg.SetActive(true);
        }

        private void OnLoading(float arg)
        {
            Log.Info("加载中，进度：" + arg);
        }
    }
}