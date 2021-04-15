using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
        private AssetInfo _redMat = new AssetInfo("redmat", "Assets/HTFrameworkDemo/Script/Resource/Red.mat", null);
        private List<GameObject> _prefabs = new List<GameObject>();
        private Material _red;

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

        private void OnGUI()
        {
            if (GUILayout.Button("全部替换为红色材质"))
            {
                StartCoroutine(LoadRedMat());
            }
        }
        
        /// <summary>
        /// 加载红色材质
        /// </summary>
        private IEnumerator LoadRedMat()
        {
            yield return null;

            //等待加载完成
            yield return Main.m_Resource.LoadAsset<Material>(_redMat, null, (mat) =>
            {
                Log.Info("加载红色材质完成！");
                _red = mat;
            });

            for (int i = 0; i < _prefabs.Count; i++)
            {
                _prefabs[i].GetComponent<MeshRenderer>().material = _red;
            }
        }

        private void OnLoadDone(GameObject arg)
        {
            Log.Info("加载完成：" + arg.name);

            arg.SetActive(true);
            arg.transform.position = Vector3.zero + new Vector3(0, 0, _prefabs.Count * 2);
            Main.m_Controller.SetLookPoint(arg.transform.position);
            _prefabs.Add(arg);
        }

        private void OnLoading(float arg)
        {
            Log.Info("加载中，进度：" + arg);
        }
    }
}