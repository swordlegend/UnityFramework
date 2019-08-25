using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : IAnimState
{
    #region 继承

    public JumpState(Entity entity)
        : base(entity)
    {
        m_stateType = (int)AnimStateType.jump;
    }

    public override void OnEnter()
    {
        
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        
    }

    #endregion
}
