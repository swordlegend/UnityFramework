﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : Character
{
    #region 函数

    public MainCharacter()
    {
        m_animStateMgr = AnimStateFactory.CreateStateMgr(this);
    }

    #endregion
}
