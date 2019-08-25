using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public abstract class Entity
    {
        #region 变量

        private Vector3 m_postion;
        /// <summary>
        /// 位置
        /// </summary>
        public Vector3 position
        {
            get { return m_postion; }
            set { m_postion = position; }
        }


        private GameObject m_gameObject;
        /// <summary>
        /// 游戏物体
        /// </summary>
        protected GameObject gameObject
        {
            get { return m_gameObject; }
            set { m_gameObject = value; }
        }


        protected AnimStateMgr m_animStateMgr = null;
        /// <summary>
        /// 动画状态机
        /// </summary>
        public AnimStateMgr animStateMgr
        {
            get { return m_animStateMgr; }
        }

        #endregion

        #region 函数

        public Entity()
        {

        }

        #endregion
    }
}

