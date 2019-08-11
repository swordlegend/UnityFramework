using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using fbs;

namespace gtmGame
{
    public class LoginModel : ClientSingleton<LoginModel>, IManager
    {
        #region 继承

        public void DoClose()
        {

        }

        public void DoInit()
        {
            GameMgr.instance.msgDispatcher.Register((uint)fbs.MsgId.RspLogin, RspLogin_SC);
        }

        public void DoUpdate()
        {
            
        }

        #endregion

        #region 消息

        private void RspLogin_SC(byte[] bytearray)
        {

        }

        #endregion
    }
}
