using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using System;
using gtmEngine.Net;
using FlatBuffers;
using System.Reflection;

namespace gtmEngine
{
    public class MsgDispatcher : IMsgDispatcher
    {
        #region 变量

        /// <summary>
        /// 消息句柄
        /// </summary>
        //private static Dictionary<uint, IMsgProcFunc> m_Handle = new Dictionary<uint, IMsgProcFunc>();

        /// <summary>
        /// fb消息句柄
        /// </summary>
        private static Dictionary<ulong, Action<object>> m_FbHandle = new Dictionary<ulong, Action<object>>();

        #endregion

        #region 继承

        public override void Dispatcher(ulong msgid, byte[] bytearray)
        {
            //if (!m_Handle.ContainsKey(msgid))
            //    return;

            //m_Handle[msgid].Invoke(bytearray);


            if (m_MsgType == IMsgType.FlatBuffer)
            {
                DispatcherFbMsg(msgid, bytearray);
            }
        }

        public override void DoClose()
        {
            //m_Handle.Clear();

            m_FbHandle.Clear();
        }

        public override void DoInit()
        {
            
        }

        public override void DoUpdate()
        {
            
        }

        //public override void Register(uint msgid, IMsgProcFunc msg)
        //{
        //    if (!m_Handle.ContainsKey(msgid))
        //    {
        //        m_Handle.Add(msgid, msg);
        //    }
        //    else
        //    {
        //        m_Handle[msgid] += msg;
        //    }
        //}

        //public override void UnRegister(uint msgid, IMsgProcFunc msg)
        //{
        //    if (m_Handle.ContainsKey(msgid))
        //    {
        //        m_Handle[msgid] -= msg;
        //    }
        //}

        //public override void SendMsg(uint msgid, byte[] bytearray)
        //{
        //    gtmInterface.ByteBuffer buff = new gtmInterface.ByteBuffer();
        //    UInt16 lengh = (UInt16)(bytearray.Length + 2);
        //    buff.WriteShort(lengh);
        //    buff.WriteUlong((ulong)msgid);
        //    buff.WriteBytes(bytearray);

        //    if (NetManager.instance != null)
        //    {
        //        NetManager.instance.SendMessage(buff);
        //    }
        //}

        public override void RegisterFBMsg<T>(Action<T> fbfunc)
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField("HashID");
            ulong hashid = (ulong)fieldInfo.GetValue(null);

            //if (!m_FbHandle.ContainsKey(hashid))
            //{
            //    m_FbHandle.Add(hashid, fbfunc);
            //}
            //else
            //{
            //    m_FbHandle[hashid] += fbfunc;
            //}
        }

        public override void UnRegisterFBMsg<T>(Action<T> fbfunc)
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField("HashID");
            ulong hashid = (ulong)fieldInfo.GetValue(null);

            //if (m_FbHandle.ContainsKey(hashid))
            //{
            //    m_FbHandle[hashid] -= fbfunc;
            //}
        }

        public override void SendFBMsg<T>(FlatBufferBuilder builder)
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField("HashID");
            ulong hashid = (ulong)fieldInfo.GetValue(null);

            byte[] bytearray = builder.DataBuffer.ToSizedArray();

            gtmInterface.ByteBuffer buff = new gtmInterface.ByteBuffer();
            UInt16 lengh = (UInt16)(bytearray.Length + sizeof(ulong));
            buff.WriteShort(lengh);
            buff.WriteUlong(hashid);
            buff.WriteBytes(bytearray);

            if (NetManager.instance != null)
            {
                NetManager.instance.SendMessage(buff);
            }
        }

        private void DispatcherFbMsg(ulong msgid, byte[] bytearray)
        {
            //FlatBuffers.ByteBuffer byteBuffer = new FlatBuffers.ByteBuffer(bytearray);
            //fbs.RspLogin msg = fbs.RspLogin.GetRootAsRspLogin(byteBuffer);

            //if (m_FbHandle.ContainsKey(msgid))
            //{
            //    m_FbHandle[msgid].Invoke(msg);
            //}
        }

        #endregion
    }
}
