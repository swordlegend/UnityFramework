using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimStateType
{
    invalid,
    idle,
    move,
    attack,
    jump
}

public abstract class IAnimState
{

    protected int m_stateType;
    /// <summary>
    /// 状态类型
    /// </summary>
    public int stateType
    {
        get { return m_stateType; }
    }

    /// <summary>
    /// entity
    /// </summary>
    protected Entity m_entity;

    public IAnimState(Entity entity)
    {
        m_entity = entity;
    }

    public abstract void OnEnter();

    public abstract void OnExit();

    public abstract void OnUpdate();
}
