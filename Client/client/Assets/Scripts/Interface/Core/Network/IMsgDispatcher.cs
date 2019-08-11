using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public interface IMsgDispatcher : IManager
    {
        void Register(uint rspLogin, Action<byte[]> msg);

        void UnRegister(uint msgid, Action<byte[]> msg);

        void SendMsg(uint msgid, byte[] bytearray);
    }
}
