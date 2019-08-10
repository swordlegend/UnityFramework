using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;

namespace gtmGame
{
    public class LoginModel : ClientSingleton<LoginModel>, IManager
    {
        #region 继承

        public void DoClose()
        {
            GameMgr.instance.msgDispatcher.UnRegister(1, null);
            GameMgr.instance.msgDispatcher.UnRegister(2, null);
        }

        public void DoInit()
        {
            GameMgr.instance.msgDispatcher.Register(1, null);
            GameMgr.instance.msgDispatcher.Register(2, null);
        }

        public void DoUpdate()
        {
            
        }

        #endregion
    }
}
