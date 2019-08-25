using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IAnimState
{
    #region 继承

    public IdleState(Entity entity)
        : base(entity)
    {
        m_stateType = (int)AnimStateType.idle;
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
