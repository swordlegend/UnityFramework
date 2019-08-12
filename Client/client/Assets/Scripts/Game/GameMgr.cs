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
        private INetManager mNetMgr = new NetManager();

        /// <summary>
        /// 日志
        /// </summary>
        private ILogSystem mLogSystem = new LogSystem();

        /// <summary>
        /// 消息分发
        /// </summary>
        private IMsgDispatcher mMsgDispatcher = new MsgDispatcher();

        public void DoInit()
        {
            mNetMgr.DoInit();
            mLogSystem.DoInit();
            mMsgDispatcher.DoInit();
        }

        public void DoUpdate()
        {
            mNetMgr.DoUpdate();
            mLogSystem.DoUpdate();
            mMsgDispatcher.DoUpdate();
        }

        public void DoClose()
        {
            mNetMgr.DoClose();
            mLogSystem.DoClose();
            mMsgDispatcher.DoClose();
        }
    }
}

