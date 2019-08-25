using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mount : MovableEntity
{
    #region 函数

    public Mount()
    {
        m_animStateMgr = AnimStateFactory.CreateStateMgr(this);
    }

    #endregion
}
