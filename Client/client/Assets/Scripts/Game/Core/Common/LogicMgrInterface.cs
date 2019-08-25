using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public interface LogicMgrInterface
    {
        void DoInit();

        void DoClose();

        void DoUpdate();
    }
}

