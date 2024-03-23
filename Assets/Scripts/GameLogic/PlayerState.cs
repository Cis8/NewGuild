using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerState : MonoBehaviour
    {
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
            RunningNW
        }

        [SerializeField] private CombatInput _combatInput;
        private float _lockedTill;
        private State _currentState;

        public CombatInput CombatInput { get => _combatInput; set => _combatInput = value; }
        public State CurrentState { get => _currentState; private set => _currentState = value; }
        public float LockedTill { get => _lockedTill; set => _lockedTill = value; }

        void Start() {
            
        }

        void Update() {
            var playerDirection = CombatInput.GetDirection();
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
                }
            }
        }

        // TODO maybe could be the default return in the firewall pattern? In such case remove this method
        private bool IsIdle() {
            return !IsStateLocked() && CombatInput.GetMovementVector().magnitude == 0;
        }

        private bool IsRunning() {
            return !IsStateLocked() && CombatInput.GetMovementVector().magnitude > 0;
        }

        private bool IsStateLocked() {
            return Time.time < LockedTill;
        }
    }
}
