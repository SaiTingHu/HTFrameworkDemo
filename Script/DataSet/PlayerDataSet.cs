using System;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 玩家数据集
    /// </summary>
    [Serializable]
    [CreateAssetMenu(menuName = "HTFramework DataSet/玩家数据集")]
    public class PlayerDataSet : DataSetBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name;
        /// <summary>
        /// 性别
        /// </summary>
        public Sex Sex = Sex.Man;
        
        /// <summary>
        /// 不需要序列化保存的，定义为属性
        /// </summary>
        public int CurrentLevel { get; set; } = 0;

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
    }

    public enum Sex
    {
        Man,
        Woman
    }
}