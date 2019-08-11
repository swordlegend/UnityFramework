using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using System;

namespace gtmEngine
{
    public class MsgDispatcher : Singleton<MsgDispatcher>, IMsgDispatcher
    {
        private Dictionary<uint, Action<byte[]>> mHandle = new Dictionary<uint, Action<byte[]>>();

        public void Dispatcher(ushort msgid, byte[] bytearray)
        {
            if (!mHandle.ContainsKey(msgid))
                return;

            mHandle[msgid].Invoke(bytearray);
        }

        public void DoClose()
        {
            mHandle.Clear();
        }

        public void DoInit()
        {
            mHandle.Clear();
        }

        public void DoUpdate()
        {
            
        }

        public void Register(uint msgid, Action<byte[]> msg)
        {
            if (!mHandle.ContainsKey(msgid))
            {
                mHandle.Add(msgid, msg);
            }
            else
            {
                mHandle[msgid] += msg;
            }
        }

        public void UnRegister(uint msgid, Action<byte[]> msg)
        {
            if (mHandle.ContainsKey(msgid))
            {
                mHandle[msgid] -= msg;
            }
        }
    }
}
