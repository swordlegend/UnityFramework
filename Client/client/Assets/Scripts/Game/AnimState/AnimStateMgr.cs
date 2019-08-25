using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStateMgr
{
    /// <summary>
    /// 动画状态
    /// </summary>
    private Dictionary<int, IAnimState> m_stateDict = new Dictionary<int, IAnimState>(8);


    private int m_curState = (int)AnimStateType.invalid;
    /// <summary>
    /// 当前状态
    /// </summary>
    public int curState
    {
        get { return m_curState; }
        set { m_curState = value; }
    }

    /// <summary>
    /// 创建状态
    /// </summary>
    /// <param name="state"></param>
    public void CreateState(IAnimState state)
    {
        if (m_stateDict.ContainsKey(state.stateType))
            return;

        m_stateDict.Add(state.stateType, state);
    }

    public void ChangeState(int statetype)
    {
        if (m_curState == statetype)
            return;

        IAnimState prestate = null;
        if (m_stateDict.TryGetValue(m_curState, out prestate))
        {
            if (prestate != null)
            {
                prestate.OnExit();
            }
        }

        m_curState = statetype;

        IAnimState curstate = null;
        if (m_stateDict.TryGetValue(m_curState, out curstate))
        {
            if (curstate != null)
            {
                curstate.OnEnter();
            }
        }
    }

    public void UpdateState()
    {
        IAnimState curstate = null;
        if (m_stateDict.TryGetValue(m_curState, out curstate))
        {
            if (curstate != null)
            {
                curstate.OnUpdate();
            }
        }
    }
}

public class AnimStateFactory
{
    public static AnimStateMgr CreateStateMgr(Npc npc)
    {
        AnimStateMgr mgr = new AnimStateMgr();

        mgr.CreateState(new IdleState(npc));
        mgr.CreateState(new MoveState(npc));
        mgr.CreateState(new AttackState(npc));
        mgr.CreateState(new JumpState(npc));
        mgr.ChangeState((int)AnimStateType.idle);

        return mgr;
    }

    public static AnimStateMgr CreateStateMgr(Mount mount)
    {
        AnimStateMgr mgr = new AnimStateMgr();

        mgr.CreateState(new IdleState(mount));
        mgr.CreateState(new MoveState(mount));
        mgr.CreateState(new AttackState(mount));
        mgr.CreateState(new JumpState(mount));
        mgr.ChangeState((int)AnimStateType.idle);

        return mgr;
    }

    public static AnimStateMgr CreateStateMgr(Character cha)
    {
        AnimStateMgr mgr = new AnimStateMgr();

        mgr.CreateState(new IdleState(cha));
        mgr.CreateState(new MoveState(cha));
        mgr.CreateState(new AttackState(cha));
        mgr.CreateState(new JumpState(cha));
        mgr.ChangeState((int)AnimStateType.idle);

        return mgr;
    }

    public static AnimStateMgr CreateStateMgr(MainCharacter cha)
    {
        AnimStateMgr mgr = new AnimStateMgr();

        mgr.CreateState(new IdleState(cha));
        mgr.CreateState(new MoveState(cha));
        mgr.CreateState(new AttackState(cha));
        mgr.CreateState(new JumpState(cha));
        mgr.ChangeState((int)AnimStateType.idle);

        return mgr;
    }
}
