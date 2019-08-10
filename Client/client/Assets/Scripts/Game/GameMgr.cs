using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmEngine;
using gtmInterface;

namespace gtmGame
{
    public class GameMgr : ClientSingleton<GameMgr>, IManager
    {
        private INetManager mNetMgr = new NetManager();
        /// <summary>
        /// 网络
        /// </summary>
        public INetManager netMgr
        {
            get { return mNetMgr; }
        }

        private ILogSystem mLogSystem = new LogSystem();
        /// <summary>
        /// 日志
        /// </summary>
        public ILogSystem logSystem
        {
            get { return mLogSystem; }
        }

        private IMsgDispatcher mMsgDispatcher = new MsgDispatcher();
        /// <summary>
        /// 消息分发
        /// </summary>
        public IMsgDispatcher msgDispatcher
        {
            get { return mMsgDispatcher; }
        }

        public void DoInit()
        {
            mNetMgr.DoInit();
            mLogSystem.DoInit();
        }

        public void DoUpdate()
        {
            mNetMgr.DoUpdate();
            mLogSystem.DoUpdate();
        }

        public void DoClose()
        {
            mNetMgr.DoClose();
            mLogSystem.DoClose();
        }
    }
}

