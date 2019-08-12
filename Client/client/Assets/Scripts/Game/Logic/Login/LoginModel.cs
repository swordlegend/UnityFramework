using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using fbs;
using FlatBuffers;

namespace gtmGame
{
    public class LoginModel : ClientSingleton<LoginModel>, LogicMgrInterface
    {
        #region 继承

        public void DoInit()
        {
            IMsgDispatcher.instance.Register((uint)fbs.MsgId.RspLogin, RspLogin_SC);
            IMsgDispatcher.instance.Register((uint)fbs.MsgId.ReqLogin, ReqLogin_SC);
        }

        public void DoClose()
        {
            IMsgDispatcher.instance.UnRegister((uint)fbs.MsgId.RspLogin, RspLogin_SC);
            IMsgDispatcher.instance.UnRegister((uint)fbs.MsgId.ReqLogin, ReqLogin_SC);
        }

        public void DoUpdate()
        {
            
        }

        #endregion

        #region 消息

        private void RspLogin_SC(byte[] bytearray)
        {
            ILogSystem.instance.Log("RspLogin_SC " + bytearray.ToString());

            FlatBuffers.ByteBuffer byteBuffer = new FlatBuffers.ByteBuffer(bytearray);
            fbs.RspLogin msg = fbs.RspLogin.GetRootAsRspLogin(byteBuffer);

            ILogSystem.instance.Log(msg.Account);
            ILogSystem.instance.Log(msg.Password);
            ILogSystem.instance.Log(msg.Isok);
        }

        private void ReqLogin_SC(byte[] bytearray)
        {
            ILogSystem.instance.Log("ReqLogin_SC : " + bytearray.ToString());

            FlatBuffers.ByteBuffer byteBuffer = new FlatBuffers.ByteBuffer(bytearray);
            fbs.ReqLogin msg = fbs.ReqLogin.GetRootAsReqLogin(byteBuffer);
            ILogSystem.instance.Log(msg.Account);
            ILogSystem.instance.Log(msg.Password);
        }

        #endregion
    }
}
