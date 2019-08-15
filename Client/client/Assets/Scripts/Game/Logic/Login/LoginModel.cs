using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using fbs;
using FlatBuffers;
using System;

namespace gtmGame
{
    public class LoginModel : ClientSingleton<LoginModel>, LogicMgrInterface
    {
        #region 继承

        public void DoInit()
        {
            //IMsgDispatcher.instance.Register((uint)fbs.MsgId.RspLogin, RspLogin_SC);
            //IMsgDispatcher.instance.Register((uint)fbs.MsgId.ReqLogin, ReqLogin_SC);

            IMsgDispatcher.instance.RegisterFBMsg<fbs.RspLogin>(RspLogin_SC);
            IMsgDispatcher.instance.RegisterFBMsg<fbs.ReqLogin>(ReqLogin_SC);
        }

        public void DoClose()
        {
            //IMsgDispatcher.instance.UnRegister((uint)fbs.MsgId.RspLogin, RspLogin_SC);
            //IMsgDispatcher.instance.UnRegister((uint)fbs.MsgId.ReqLogin, ReqLogin_SC);

            IMsgDispatcher.instance.UnRegisterFBMsg<fbs.RspLogin>(RspLogin_SC);
            IMsgDispatcher.instance.UnRegisterFBMsg<fbs.ReqLogin>(ReqLogin_SC);
        }

        public void DoUpdate()
        {
            
        }

        #endregion

        #region 消息

        //private void RspLogin_SC(byte[] bytearray)
        //{
        //    ILogSystem.instance.Log("RspLogin_SC " + bytearray.ToString());

        //    FlatBuffers.ByteBuffer byteBuffer = new FlatBuffers.ByteBuffer(bytearray);
        //    fbs.RspLogin msg = fbs.RspLogin.GetRootAsRspLogin(byteBuffer);

        //    ILogSystem.instance.Log(msg.Account);
        //    ILogSystem.instance.Log(msg.Password);
        //}

        //private void ReqLogin_SC(byte[] bytearray)
        //{
        //    ILogSystem.instance.Log("ReqLogin_SC : " + bytearray.ToString());

        //    FlatBuffers.ByteBuffer byteBuffer = new FlatBuffers.ByteBuffer(bytearray);
        //    fbs.ReqLogin msg = fbs.ReqLogin.GetRootAsReqLogin(byteBuffer);
        //    ILogSystem.instance.Log(msg.Account);
        //    ILogSystem.instance.Log(msg.Password);
        //}

        private void RspLogin_SC(fbs.RspLogin msg)
        {
            ILogSystem.instance.Log(msg.Account);
            ILogSystem.instance.Log(msg.Password);
        }

        private void ReqLogin_SC(fbs.ReqLogin msg)
        {
            ILogSystem.instance.Log(msg.Account);
            ILogSystem.instance.Log(msg.Password);

        }

        #endregion
    }
}
