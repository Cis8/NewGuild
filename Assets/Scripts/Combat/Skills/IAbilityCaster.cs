using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public interface IAbilityCaster
    {
        public UnityAction<float> Ability { get; set; }
    }
}
