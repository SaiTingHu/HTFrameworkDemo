using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 数据集测试
    /// </summary>
    public class DataSetTest : MonoBehaviour
    {
        private LevelDataSet _level;
        private PlayerDataSet _player;

        private void Awake()
        {
            _level = Main.Current.GetDataSetParameter("Level") as LevelDataSet;
            _player = Main.Current.GetDataSetParameter("Player") as PlayerDataSet;

            Main.m_DataSet.AddDataSet(_level);
            Main.m_DataSet.AddDataSet(_player);
        }

        private void Start()
        {
            _player.CurrentLevel = 1;
            Log.Info("当前玩家：" + _player.Name + " 性别：" + _player.Sex + " 关卡：" + _level.Levels[_player.CurrentLevel].Name);
        }
    }
}