using NewGuild.Utils;
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

    public class CombatInput : MonoBehaviour
    {
        private PlayerInputActions _playerInputActions;
        private Direction _lastDirection;

        public PlayerInputActions PlayerInputActions { get => _playerInputActions; set => _playerInputActions = value; }
        public Direction LastDirection { get => _lastDirection; set => _lastDirection = value; }

        private void Awake() {
            PlayerInputActions = new PlayerInputActions();
            PlayerInputActions.Player.Enable();
        }

        public Vector3 GetMovementVector() {
            var inputVector = PlayerInputActions.Player.Run.ReadValue<Vector2>();
            return new Vector3(inputVector.x, 0, inputVector.y).ToIso();
        }

        public Direction GetDirection() {
            Vector2 inputVector = PlayerInputActions.Player.Run.ReadValue<Vector2>();
            if (inputVector.x > 0 && inputVector.y > 0) {
                LastDirection = Direction.NE;
            } else if (inputVector.x > 0 && inputVector.y < 0) {
                LastDirection = Direction.SE;
            } else if (inputVector.x < 0 && inputVector.y < 0) {
                LastDirection = Direction.SW;
            } else if (inputVector.x < 0 && inputVector.y > 0) {
                LastDirection = Direction.NW;
            } else if (inputVector.x > 0) {
                LastDirection = Direction.E;
            } else if (inputVector.x < 0) {
                LastDirection = Direction.W;
            } else if (inputVector.y > 0) {
                LastDirection = Direction.N;
            } else if (inputVector.y < 0) {
                LastDirection = Direction.S;
            }
            return LastDirection;
        }
    }
}
