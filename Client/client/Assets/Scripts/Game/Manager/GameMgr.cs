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
        private INetManager m_netMgr = new NetManager();

        /// <summary>
        /// 日志
        /// </summary>
        private ILogSystem m_logSystem = new LogSystem();

        /// <summary>
        /// 消息分发
        /// </summary>
        private IMsgDispatcher m_msgDispatcher = new MsgDispatcher();

        /// <summary>
        /// 资源加载
        /// </summary>
        private IResourceLoad m_resLoad = new ResourceLoad();

        /// <summary>
        /// lua管理
        /// </summary>
        private LuaManager m_luaMgr = null;

        /// <summary>
        /// ui管理
        /// </summary>
        private UIManager m_uiMgr = null;

        #region 继承函数

        public void DoInit()
        {
            m_netMgr.DoInit();

            m_logSystem.EnableSave();
            m_logSystem.DoInit();

            m_msgDispatcher.RegisterMsgType(IMsgType.FlatBuffer);
            m_msgDispatcher.DoInit();

            m_resLoad.DoInit();

            m_luaMgr = LuaManager.instance;
            m_luaMgr.DoInit();

            m_uiMgr = UIManager.instance;
            m_uiMgr.DoInit();
        }

        public void DoUpdate()
        {
            m_uiMgr.DoUpdate();
            m_netMgr.DoUpdate();
            m_logSystem.DoUpdate();
            m_msgDispatcher.DoUpdate();
            m_luaMgr.DoUpdate();
            m_resLoad.DoUpdate();
        }

        public void DoClose()
        {
            m_uiMgr.DoClose();
            m_netMgr.DoClose();
            m_logSystem.DoClose();
            m_msgDispatcher.DoClose();
            m_resLoad.DoClose();
            m_luaMgr.DoClose();
        }

        #endregion
    }
}

