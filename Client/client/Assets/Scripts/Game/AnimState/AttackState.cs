using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public class AttackState : IAnimState
    {
        #region 继承

        public AttackState(Entity entity)
            : base(entity)
        {
            m_stateType = (int)AnimStateType.attack;
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
}

