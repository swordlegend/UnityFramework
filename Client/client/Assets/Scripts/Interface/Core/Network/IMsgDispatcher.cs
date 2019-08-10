using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public interface IMsgDispatcher
    {
        void Register(uint msgid, GameEvent<byte[]> msg);

        void UnRegister(uint msgid, GameEvent<byte[]> msg);
    }
}
