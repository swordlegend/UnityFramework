using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public interface IManager
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void DoInit();

        /// <summary>
        /// 刷新
        /// </summary>
        void DoUpdate();

        /// <summary>
        /// 关闭
        /// </summary>
        void DoClose();
    }
}
