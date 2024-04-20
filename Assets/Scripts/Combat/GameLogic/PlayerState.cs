using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerState : MonoBehaviour
    {
        // TODO refactor so that only one Idle and one Running state is used
        // The animator will use the direction to determine the animation
        public enum State {
            // Idle states
            IdleN,
            IdleNE,
            IdleE,
            IdleSE,
            IdleS,
            IdleSW,
            IdleW,
            IdleNW,
            // Running states
            RunningN,
            RunningNE,
            RunningE,
            RunningSE,
            RunningS,
            RunningSW,
            RunningW,
            RunningNW,
        }

        [SerializeField] private PlayerMovementInputHandler _combatInput;
        private float _lockedTill = 0;
        private State _currentState;

        public State CurrentState { get => _currentState; private set => _currentState = value; }

        void Start() {
            
        }

        void Update() {
            var playerDirection = _combatInput.GetDirection();
            if (IsRunning()) {
                switch (playerDirection) {
                    case Direction.N:
                        CurrentState = State.RunningN;
                        break;
                    case Direction.NE:
                        CurrentState = State.RunningNE;
                        break;
                    case Direction.E:
                        CurrentState = State.RunningE;
                        break;
                    case Direction.SE:
                        CurrentState = State.RunningSE;
                        break;
                    case Direction.S:
                        CurrentState = State.RunningS;
                        break;
                    case Direction.SW:
                        CurrentState = State.RunningSW;
                        break;
                    case Direction.W:
                        CurrentState = State.RunningW;
                        break;
                    case Direction.NW:
                        CurrentState = State.RunningNW;
                        break;
                }
            } else if(IsIdle()) {
                switch (playerDirection) {
                    case Direction.N:
                        CurrentState = State.IdleN;
                        break;
                    case Direction.NE:
                        CurrentState = State.IdleNE;
                        break;
                    case Direction.E:
                        CurrentState = State.IdleE;
                        break;
                    case Direction.SE:
                        CurrentState = State.IdleSE;
                        break;
                    case Direction.S:
                        CurrentState = State.IdleS;
                        break;
                    case Direction.SW:
                        CurrentState = State.IdleSW;
                        break;
                    case Direction.W:
                        CurrentState = State.IdleW;
                        break;
                    case Direction.NW:
                        CurrentState = State.IdleNW;
                        break;
                }
            }
        }

        // TODO maybe could be the default return in the firewall pattern? In such case remove this method
        private bool IsIdle() {
            return !IsLocked() && !_combatInput.IsMoving();
        }

        private bool IsRunning() {
            return !IsLocked() && _combatInput.IsMoving();
        }

        public bool IsLocked() {
            return Time.time < _lockedTill;
        }
    }
}
