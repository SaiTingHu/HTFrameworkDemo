using System;
using System.Collections.Generic;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 关卡数据集
    /// </summary>
    [Serializable]
    [CreateAssetMenu(menuName = "HTFramework DataSet/关卡数据集")]
    public class LevelDataSet : DataSetBase
    {
        /// <summary>
        /// 所有关卡
        /// </summary>
        public List<Level> Levels = new List<Level>();

        /// <summary>
        /// 通过Json数据填充数据集
        /// </summary>
        public override void Fill(JsonData data)
        {

        }

        /// <summary>
        /// 将数据集打包为Json数据
        /// </summary>
        public override JsonData Pack()
        {
            JsonData data = new JsonData();
            return data;
        }

        [Serializable]
        public sealed class Level
        {
            public string Name;
            public int MonsterLevel;
            public int MonsterIQ;
            public int MonsterCount;
        }
    }
}