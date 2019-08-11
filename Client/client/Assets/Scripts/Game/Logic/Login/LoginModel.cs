using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using fbs;
using FlatBuffers;

namespace gtmGame
{
    public class LoginModel : ClientSingleton<LoginModel>, IManager
    {
        #region 继承

        public void DoInit()
        {
            GameMgr.instance.msgDispatcher.Register((uint)fbs.MsgId.RspLogin, RspLogin_SC);
            GameMgr.instance.msgDispatcher.Register((uint)fbs.MsgId.ReqLogin, ReqLogin_SC);
        }

        public void DoClose()
        {
            GameMgr.instance.msgDispatcher.UnRegister((uint)fbs.MsgId.RspLogin, RspLogin_SC);
            GameMgr.instance.msgDispatcher.UnRegister((uint)fbs.MsgId.ReqLogin, ReqLogin_SC);
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

        private void ReqLogin_SC(byte[] bytearray)
        {
            GameMgr.instance.logSystem.Log("ReqLogin_SC : " + bytearray.ToString());

            ByteBuffer byteBuffer = new ByteBuffer(bytearray);
            fbs.ReqLogin msg = fbs.ReqLogin.GetRootAsReqLogin(byteBuffer);
            GameMgr.instance.logSystem.Log(msg.Account);
            GameMgr.instance.logSystem.Log(msg.Password);
        }

        #endregion
    }
}
