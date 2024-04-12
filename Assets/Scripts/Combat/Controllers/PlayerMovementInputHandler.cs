using NewGuild.Combat.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NewGuild.Combat
{
    public enum Direction {         
        N,
        NE,
        E,
        SE,
        S,
        SW,
        W,
        NW
    }

    public class PlayerMovementInputHandler : MovementHandler
    {
        private PlayerInputActions _playerInputActions;
        private Direction _lastDirection;


        private void Awake() {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
        }

        public override Vector3 GetMovementVector() {
            var inputVector = _playerInputActions.Player.Run.ReadValue<Vector2>();
            return new Vector3(inputVector.x, inputVector.y, 0).ToIso();
        }

        public Direction GetDirection() {
            Vector2 inputVector = _playerInputActions.Player.Run.ReadValue<Vector2>();
            if (inputVector.x > 0 && inputVector.y > 0) {
                _lastDirection = Direction.NE;
            } else if (inputVector.x > 0 && inputVector.y < 0) {
                _lastDirection = Direction.SE;
            } else if (inputVector.x < 0 && inputVector.y < 0) {
                _lastDirection = Direction.SW;
            } else if (inputVector.x < 0 && inputVector.y > 0) {
                _lastDirection = Direction.NW;
            } else if (inputVector.x > 0) {
                _lastDirection = Direction.E;
            } else if (inputVector.x < 0) {
                _lastDirection = Direction.W;
            } else if (inputVector.y > 0) {
                _lastDirection = Direction.N;
            } else if (inputVector.y < 0) {
                _lastDirection = Direction.S;
            }
            return _lastDirection;
        }
    }
}
