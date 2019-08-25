using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public class Npc : MovableEntity
    {
        #region 函数

        public Npc()
        {
            m_animStateMgr = AnimStateFactory.CreateStateMgr(this);
        }

        #endregion
    }
}

