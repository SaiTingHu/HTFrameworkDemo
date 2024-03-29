using System;
using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 自定义模块 - 时间模块
    /// </summary>
    [CustomModule("时间模块", true)]
    public class TimeModule : CustomModuleBase
    {
        private float _timer = 0;

        /// <summary>
        /// 是否运行中
        /// </summary>
        public override bool IsRunning
        {
            get
            {
                return base.IsRunning;
            }
            set
            {
                base.IsRunning = value;
            }
        }

        /// <summary>
        /// 初始化模块
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();
        }

        /// <summary>
        /// 模块准备工作
        /// </summary>
        public override void OnReady()
        {
            base.OnReady();

            IsRunning = false;
        }

        /// <summary>
        /// 刷新模块
        /// </summary>
        public override void OnUpdate()
        {
            base.OnUpdate();

            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
            }
            else
            {
                _timer = 1;
                Log.Info("当前时间:" + DateTime.Now.ToDefaultDateString());
            }
        }

        /// <summary>
        /// 终结模块
        /// </summary>
        public override void OnTerminate()
        {
            base.OnTerminate();
        }

        /// <summary>
        /// 暂停模块
        /// </summary>
        public override void OnPause()
        {
            base.OnPause();
        }

        /// <summary>
        /// 恢复模块
        /// </summary>
        public override void OnResume()
        {
            base.OnResume();
        }
    }
}