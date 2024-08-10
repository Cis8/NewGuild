using NewGuild.Combat.Skills;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public abstract class AtkAbilityController : MonoBehaviour, IAttacker, IAbilityCaster
    {
        public abstract UnityAction<float> Attack { get; set; }

        public abstract UnityAction<float> Ability { get; set; }

        protected virtual void Start() {
        
        }

        protected virtual void Update() {
        
        }

        protected abstract bool IsAttackCancellable();

        protected abstract bool IsAbilityCancellable();
    }
}
