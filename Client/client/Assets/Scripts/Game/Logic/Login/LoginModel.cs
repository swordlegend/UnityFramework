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
            GameMgr.instance.msgDispatcher.UnRegister((uint)fbs.MsgId.RspLogin, RspLogin_SC);
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
            GameMgr.instance.logSystem.Log("RspLogin_SC " + bytearray.ToString());
        }

        #endregion
    }
}
