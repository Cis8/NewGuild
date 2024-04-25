using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.StateMachine {
    public interface ITransition
    {
        IState To { get; }
        IPredicate Condition { get; }
    }
}
