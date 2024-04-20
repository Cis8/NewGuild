using NewGuild.Combat;
using NewGuild.Combat.Skills;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerAtkAbilityController : AtkAbilityController {

        [SerializeField] private PlayerState _playerState;
        private PlayerInputActions _playerInputActions;

        void Awake() {
            _playerInputActions = PlayerInputActionsSingleton.Instance;
        }

        public override void ExecuteAttack() {
            Debug.Log("Attack!");
        }

        public override void CastAbility() {
            Debug.Log("Ability!");
        }
        protected override bool IsAttackCancellable() {
            throw new System.NotImplementedException();
        }

        protected override bool IsAbilityCancellable() {
            throw new System.NotImplementedException();
        }

        protected override void Update() {
            if (!_playerState.IsLocked()) {
                Debug.Log("PlayerAtkAbilityController Update");
                if (_playerInputActions.Player.Attack.IsPressed()) {
                    ExecuteAttack();
                }
                if (_playerInputActions.Player.Ability.IsPressed()) {
                    CastAbility();
                }
            }
        }
    }
}
