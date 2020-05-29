using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 资源测试
    /// </summary>
    public class ResourceTest : MonoBehaviour
    {
        private void Start()
        {
            Main.m_Resource.LoadPrefab(new PrefabInfo("test", "Assets/HTFrameworkDemo/Script/Resource/Cube.prefab", ""), null, OnLoading, OnLoadDone);
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