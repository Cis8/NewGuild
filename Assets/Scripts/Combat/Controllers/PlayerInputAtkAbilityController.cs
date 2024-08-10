using NewGuild.Combat;
using NewGuild.Combat.Skills;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public class PlayerInputAtkAbilityController : AtkAbilityController {

        [SerializeField] private InputReader _inputReader;

        public override UnityAction<float> Attack { get => _inputReader.Attack; set => _inputReader.Attack = value; }

        public override UnityAction<float> Ability { get => _inputReader.Ability; set => _inputReader.Ability = value; }

        protected override bool IsAttackCancellable() {
            throw new System.NotImplementedException();
        }

        protected override bool IsAbilityCancellable() {
            throw new System.NotImplementedException();
        }

        protected override void Update() {
            /*if (!_playerState.IsLocked()) {
                Debug.Log("PlayerAtkAbilityController Update");
                if (_playerInputActions.Player.Attack.IsPressed()) {
                    ExecuteAttack();
                }
                if (_playerInputActions.Player.Ability.IsPressed()) {
                    CastAbility();
                }
            }*/
        }
    }
}
