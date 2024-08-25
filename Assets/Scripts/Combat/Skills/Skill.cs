using System;
using NewGuild.Combat.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.Skills {

    public abstract class Skill : ScriptableObject {
        [NonSerialized] private GameObject _self;

        [SerializeField] private float _cooldown;
        [NonSerialized] protected Animator _animator;

        [NonSerialized] private bool _onCooldown = false;

        public GameObject Self { get => _self; private set => _self = value; }

        public void SetupSkill(GameObject self, Animator animator) {
            _animator = animator;
            _self = self;
        }

        /// <summary>
        /// It executes the logic assigned to the start of the skill.
        /// Some checks may be performed to ensure the skill is executed.
        /// For simple abilities, all the logic relies here.
        /// </summary>
        /// <param name="other">Is the target of the skill.</param>
        abstract public void StartSkill(GameObject other = null);

        // TODO add HoldSkill

        // TODO add ReleaseSkill

        /// <summary>
        /// It is used to check wether the skill can be casted or not.
        /// The base implementation checks if the skill is on cooldown.
        /// </summary>
        protected virtual bool CanBeCasted() {
            return !_onCooldown;
        }

        // ================ Sandbox methods =================

        // These protected methods are to be used in the child classes to perform the logic of the skill

        protected void EnableCooldown() {
            _onCooldown = true;
            Util.RunFuncAfterTime(() => _onCooldown = false, _cooldown);
        }

        protected void DealDamage(GameObject other, IncomingDmg dmgInfo) {
            if (other != null && Util.IsDamageableOpponent(_self, other, out IDamageable dmgComponent)) {
                dmgComponent.TakeDamage(dmgInfo);
            }
        }

        protected void PlayAnimation(int animation) {
            _animator.Play(animation);
        }

        protected void EnableGO(GameObject toEnable) {
            toEnable.SetActive(true);
        }

        protected void DisableGO(GameObject toDisable) {
            toDisable.SetActive(false);
        }
    }
}
