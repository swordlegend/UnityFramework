using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmEngine;
using gtmInterface;

namespace gtmGame
{
    public class GameMgr : ClientSingleton<GameMgr>
    {
        private INetManager mNetMgr = new NetManager();

        public INetManager netMgr
        {
            get { return mNetMgr; }
        }

        private ILogSystem mLogSystem = new LogSystem();

        public ILogSystem logSystem
        {
            get { return mLogSystem; }
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

        public void DoDestroy()
        {
            mNetMgr.DoClose();
            mLogSystem.DoClose();
        }
    }
}

