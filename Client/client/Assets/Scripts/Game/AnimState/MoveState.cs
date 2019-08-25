using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IAnimState
{
    #region 继承

    public MoveState(Entity entity)
        : base(entity)
    {
        m_stateType = (int)AnimStateType.move;
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
