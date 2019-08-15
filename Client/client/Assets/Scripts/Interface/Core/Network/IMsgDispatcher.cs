using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlatBuffers;
using gtmEngine;

namespace gtmInterface
{
    public enum IMsgType
    {
        Invalid,
        FlatBuffer,
        Protobuf,
    }

    public abstract class IMsgDispatcher : IManager
    {
        public IMsgDispatcher()
        {
            m_sInstance = this;
        }

        protected static IMsgDispatcher m_sInstance = null;

        public static IMsgDispatcher instance
        {
            get { return m_sInstance; }
        }

        protected IMsgType m_MsgType = IMsgType.Invalid;

        //public delegate void IMsgProcFunc(byte[] bytearray);

        //public abstract void Register(uint msgid, IMsgProcFunc msg);

        //public abstract void UnRegister(uint msgid, IMsgProcFunc msg);

        //public abstract void SendMsg(uint msgid, byte[] bytearray);

        public void RegisterMsgType(IMsgType msgtype)
        {
            m_MsgType = msgtype;
        }

        public abstract void Dispatcher(ulong msgid, byte[] bytearray);

        public virtual void RegisterFBMsg<T>(Action<T> fbfunc) { }
        
        public virtual void UnRegisterFBMsg<T>(Action<T> fbfunc) { }

        public virtual void SendFBMsg<T>(FlatBufferBuilder builder) { }
    }
}
