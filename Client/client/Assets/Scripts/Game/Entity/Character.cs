using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MovableEntity
{
    #region 函数

    public Character()
    {
        m_animStateMgr = AnimStateFactory.CreateStateMgr(this);
    }

    #endregion
}
