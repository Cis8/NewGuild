using NewGuild.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewGuild.Combat.I8Directioned;

namespace NewGuild.Combat
{
    public class IdleState : BaseState {
        private static readonly int IdleN = Animator.StringToHash("IdleN");
        private static readonly int IdleNE = Animator.StringToHash("IdleNE");
        private static readonly int IdleE = Animator.StringToHash("IdleE");
        private static readonly int IdleSE = Animator.StringToHash("IdleSE");
        private static readonly int IdleS = Animator.StringToHash("IdleS");
        private static readonly int IdleSW = Animator.StringToHash("IdleSW");
        private static readonly int IdleW = Animator.StringToHash("IdleW");
        private static readonly int IdleNW = Animator.StringToHash("IdleNW");

        public IdleState(GameObject player, Animator animator) : base(player, animator) {
        }

        public override void FixedUpdate() {
            
        }

        public override void OnEnter() {
            switch (_entity8Direction.Direction8()) {
                case Direction.N:
                    _animator.Play(IdleN);
                    break;
                case Direction.NE:
                    _animator.Play(IdleNE);
                    break;
                case Direction.E:
                    _animator.Play(IdleE);
                    break;
                case Direction.SE:
                    _animator.Play(IdleSE);
                    break;
                case Direction.S:
                    _animator.Play(IdleS);
                    break;
                case Direction.SW:
                    _animator.Play(IdleSW);
                    break;
                case Direction.W:
                    _animator.Play(IdleW);
                    break;
                case Direction.NW:
                    _animator.Play(IdleNW);
                    break;
            }
        }

        public override void OnExit() {
            
        }

        public override void Update() {
            
        }
    }
}
