using NewGuild.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.SMachine.Player
{
    public class AttackState : BaseState {
        public AttackState(GameObject player, Animator animator) : base(player, animator) {
        }

        public override void FixedUpdate() {
            
        }

        public override void OnEnter() {
            Debug.Log("Entered AttackState");
        }

        public override void OnExit() {
            
        }

        public override void Update() {
            
        }
    }
}
