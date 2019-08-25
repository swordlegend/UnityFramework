using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public class MainCharacter : Character
    {
        #region 函数

        public MainCharacter()
        {
            m_animStateMgr = AnimStateFactory.CreateStateMgr(this);
        }

        #endregion
    }
}

