using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.StateMachine
{
    public interface IState
    {
        void OnEnter();
        void OnExit();
        void Update();
        void FixedUpdate();
    }
}
