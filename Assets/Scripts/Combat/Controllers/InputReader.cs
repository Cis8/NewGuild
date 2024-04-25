using NewGuild.Combat.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static PlayerInputActions;

namespace NewGuild.Combat
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "Combat/InputReader")]
    public class InputReader : ScriptableObject, IPlayerActions {
        private event UnityAction<Vector2> _move = delegate { };
        private event UnityAction<bool> _dash = delegate { };
        private event UnityAction _attack = delegate { };
        private event UnityAction _ability = delegate { };

        public UnityAction<Vector2> Move { get => _move; set => _move = value; }
        public UnityAction<bool> Dash { get => _dash; set => _dash = value; }
        public UnityAction Attack { get => _attack; set => _attack = value; }
        public UnityAction Ability { get => _ability; set => _ability = value; }

        PlayerInputActions _inputActions;

        private void OnEnable () {
            if (_inputActions == null) {
                _inputActions = new PlayerInputActions();
                _inputActions.Player.SetCallbacks(this);
            }
        }

        public void EnablePlayerActions() {
            _inputActions.Enable();
        }

        public void OnMove(InputAction.CallbackContext context) {
            switch (context.phase) {
                case InputActionPhase.Started:
                    _move.Invoke(context.ReadValue<Vector2>());
                    break;
                case InputActionPhase.Canceled:
                    _move.Invoke(context.ReadValue<Vector2>());
                    break;
            }
        }

        public void OnDash(InputAction.CallbackContext context) {
            _dash.Invoke(context.ReadValue<bool>());
        }

        public void OnAttack(InputAction.CallbackContext context) {
            if (context.phase == InputActionPhase.Started) {
                _attack.Invoke();
            }
        }

        public void OnAbility(InputAction.CallbackContext context) {
            if (context.phase == InputActionPhase.Started) {
                _ability.Invoke();
            }
        }

        public Vector2 GetMovementVector() {
            return _inputActions.Player.Move.ReadValue<Vector2>();
        }
    }
}
