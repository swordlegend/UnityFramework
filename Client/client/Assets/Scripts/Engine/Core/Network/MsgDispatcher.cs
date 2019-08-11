using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;
using System;
using gtmEngine.Net;

namespace gtmEngine
{
    public class MsgDispatcher : Singleton<MsgDispatcher>, IMsgDispatcher
    {
        private static Dictionary<uint, Action<byte[]>> mHandle = new Dictionary<uint, Action<byte[]>>();

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
            _instance = this;
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

        public void SendMsg(uint msgid, byte[] bytearray)
        {
            ByteBuffer buff = new ByteBuffer();
            UInt16 lengh = (UInt16)(bytearray.Length + 2);
            buff.WriteShort((UInt16)lengh);
            buff.WriteShort((UInt16)msgid);
            buff.WriteBytes(bytearray);
            NetManager.instance.SendMessage(buff);
        }
    }
}
