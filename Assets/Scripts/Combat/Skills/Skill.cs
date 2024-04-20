using System;
using NewGuild.Combat.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.Skills {

    public abstract class Skill : ScriptableObject {
        [NonSerialized] private GameObject _self;

        private float _cooldown;

        [NonSerialized] private bool _onCooldown = false;

        public GameObject Self { get => _self; set => _self = value; }

        /// <summary>
        /// It executes the logic assigned to the start of the skill.
        /// Some checks may be performed to ensure the skill is executed.
        /// For simple abilities, all the logic relies here.
        /// </summary>
        /// <param name="other">Is the target of the skill. It must be the Main Game Object of the entity.</param>
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
            if (Util.IsDamageableOpponent(_self, other, out IDamageable dmgComponent)) {
                dmgComponent.TakeDamage(dmgInfo);
            }
        }

        protected void EnableGO(GameObject toEnable) {
            toEnable.SetActive(true);
        }

        protected void DisableGO(GameObject toDisable) {
            toDisable.SetActive(false);
        }
    }
}
