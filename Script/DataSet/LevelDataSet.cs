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