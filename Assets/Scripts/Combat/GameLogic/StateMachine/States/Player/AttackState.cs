using NewGuild.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.SMachine.Player
{
    public class AttackState : BaseState {
        private EntityAttack _entityAttack;

        public AttackState(GameObject player, Animator animator) : base(player, animator) {
            if (!player.TryGetComponent(out _entityAttack)) {
                var message = "EntityAttack not found";
                Debug.LogError(message);
                throw new System.Exception(message);
            }
        }

        public override void FixedUpdate() {
            
        }

        public override void OnEnter() {
            Debug.Log("Entered AttackState");
            _entityAttack.Attack();
        }

        public override void OnExit() {
            Debug.Log("Exited AttackState");
        }

        public override void Update() {
            
        }
    }
}
