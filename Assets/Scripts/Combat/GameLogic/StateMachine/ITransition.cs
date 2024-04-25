using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.SMachine {
    public interface ITransition
    {
        IState To { get; }
        IPredicate Condition { get; }
    }
}
