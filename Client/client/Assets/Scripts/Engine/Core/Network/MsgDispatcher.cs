using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;

namespace gtmEngine
{
    public class MsgDispatcher : Singleton<MsgDispatcher>, IMsgDispatcher
    {
        private Dictionary<uint, GameEvent<byte[]>> mHandle = new Dictionary<uint, GameEvent<byte[]>>();

        public void Dispatcher(ushort msgid, byte[] bytearray)
        {
            if (!mHandle.ContainsKey(msgid))
                return;

            mHandle[msgid].Invoke(bytearray);
        }

        public void Register(uint msgid, GameEvent<byte[]> msg)
        {
            if (!mHandle.ContainsKey(msgid))
            {
                mHandle.Add(msgid, msg);
            }
        }

        public void UnRegister(uint msgid, GameEvent<byte[]> msg)
        {
            if (mHandle.ContainsKey(msgid))
            {
                mHandle.Remove(msgid);
            }
        }
    }
}
