using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewGuild.Combat.I8Directioned;

namespace NewGuild.Combat
{
    public class PlayerMovement : EntityMovement, I8Directioned
    {
        private Direction _lastDirection;

        public Direction LastDirection { get => _lastDirection; private set => _lastDirection = value; }

        protected override void Start() {
            base.Start();
        }

        // this method is used by the StateMachine to set the direction of the player on the Entity8Direction component
        public Direction Direction8() {
            Vector2 inputVector = GetDirectionV3();
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
