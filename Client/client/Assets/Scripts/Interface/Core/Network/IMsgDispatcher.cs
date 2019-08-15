using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
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

        public delegate void IMsgProcFunc(byte[] bytearray);

        public abstract void Register(uint rspLogin, IMsgProcFunc msg);

        public abstract void UnRegister(uint msgid, IMsgProcFunc msg);

        public abstract void SendMsg(uint msgid, byte[] bytearray);

        public abstract void Dispatcher(ushort msgid, byte[] bytearray);
    }
}
