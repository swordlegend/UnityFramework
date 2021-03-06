﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public class GameApplication : ClientSingleton<GameApplication>, LogicMgrInterface
    {
        #region 变量

        private GameMgr m_gameMgr = new GameMgr();
        /// <summary>
        /// ...
        /// </summary>
        public GameMgr gameMgr
        {
            get { return m_gameMgr; }
        }

        private GameLogicMgr m_gameLogicMgr = new GameLogicMgr();

        #endregion

        #region 继承函数

        public void DoClose()
        {
            m_gameLogicMgr.DoClose();
            m_gameMgr.DoClose();
        }

        public void DoInit()
        {
            m_gameMgr.DoInit();
            m_gameLogicMgr.DoInit();

            // do string
            LuaManager.instance.LoadLuaFile("main");
        }

        public void DoUpdate()
        {
            m_gameMgr.DoUpdate();
            m_gameLogicMgr.DoUpdate();
        }

        #endregion


    }
}
