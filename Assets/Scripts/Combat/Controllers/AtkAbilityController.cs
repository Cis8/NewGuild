using NewGuild.Combat.Skills;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public abstract class AtkAbilityController : MonoBehaviour, IAttacking, IAbilityCasting
    {
        protected virtual void Start() {
        
        }

        protected virtual void Update() {
        
        }

        public abstract void ExecuteAttack();

        public abstract void CastAbility();

        protected abstract bool IsAttackCancellable();

        protected abstract bool IsAbilityCancellable();
    }
}
