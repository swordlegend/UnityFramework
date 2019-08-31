using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public class GameLogicMgr : ClientSingleton<GameLogicMgr>, LogicMgrInterface
    {
        #region 变量

        //private LoginModel m_loginModel = new LoginModel();

        //private ChatModel m_chatModel = new ChatModel();

        #endregion

        #region 继承函数

        public void DoClose()
        {
            //m_loginModel.DoClose();
            //m_chatModel.DoClose();
        }

        public void DoInit()
        {
            //m_loginModel.DoInit();
            //m_chatModel.DoInit();
        }

        public void DoUpdate()
        {
            //m_loginModel.DoUpdate();
            //m_chatModel.DoUpdate();
        }

        #endregion
    }
}

