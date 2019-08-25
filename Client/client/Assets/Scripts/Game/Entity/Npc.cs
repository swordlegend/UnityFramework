using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MovableEntity
{
    #region 函数

    public Npc()
    {
        m_animStateMgr = AnimStateFactory.CreateStateMgr(this);
    }

    #endregion
}
