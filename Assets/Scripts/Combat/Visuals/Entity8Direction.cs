using NewGuild.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewGuild.Combat.I8Directioned;

namespace NewGuild.Combat
{
    // This is component to whom any component that needs to know the direction of the entity should ask to
    // It is updated by the StateMachine using the Direction8 methods of other components
    public class Entity8Direction : MonoBehaviour, I8Directioned {
        private Direction _currentDirection = Direction.N;

        public Direction Direction8() {
            return _currentDirection;
        }

        public void SetDirection(Direction direction) {
            _currentDirection = direction;
        }

        void Start() {
        
        }

        void Update() {
        
        }
    }
}
