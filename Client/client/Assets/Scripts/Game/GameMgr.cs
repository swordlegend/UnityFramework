using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmEngine;
using gtmInterface;

namespace gtmGame
{
    public class GameMgr : ClientSingleton<GameMgr>
    {
        /// <summary>
        /// 网络
        /// </summary>
        private INetManager m_NetMgr = new NetManager();

        /// <summary>
        /// 日志
        /// </summary>
        private ILogSystem m_LogSystem = new LogSystem();

        /// <summary>
        /// 消息分发
        /// </summary>
        private IMsgDispatcher m_MsgDispatcher = new MsgDispatcher();

        public void DoInit()
        {
            m_NetMgr.DoInit();
            m_LogSystem.DoInit();
            m_MsgDispatcher.DoInit();
        }

        public void DoUpdate()
        {
            m_NetMgr.DoUpdate();
            m_LogSystem.DoUpdate();
            m_MsgDispatcher.DoUpdate();
        }

        public void DoClose()
        {
            m_NetMgr.DoClose();
            m_LogSystem.DoClose();
            m_MsgDispatcher.DoClose();
        }
    }
}

