using NewGuild.Combat.SMachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static NewGuild.Combat.I8Directioned;

namespace NewGuild.Combat
{
    public class MoveState : BaseState {
        private static readonly int RunN = Animator.StringToHash("RunN");
        private static readonly int RunNE = Animator.StringToHash("RunNE");
        private static readonly int RunE = Animator.StringToHash("RunE");
        private static readonly int RunSE = Animator.StringToHash("RunSE");
        private static readonly int RunS = Animator.StringToHash("RunS");
        private static readonly int RunSW = Animator.StringToHash("RunSW");
        private static readonly int RunW = Animator.StringToHash("RunW");
        private static readonly int RunNW = Animator.StringToHash("RunNW");

        private PlayerMovement _playerMovement;

        public MoveState(GameObject player, Animator animator) : base(player, animator) {
            if (!player.TryGetComponent(out _playerMovement)) {
                var message = "PlayerMovement not found";
                Debug.LogError(message);
                throw new System.Exception(message);
            }
        }

        public override void FixedUpdate() {
            
        }

        public override void OnEnter() {
            
        }

        public override void OnExit() {
            
        }

        public override void Update() {
            _entity8Direction.SetDirection(_playerMovement.Direction8());
            switch (_entity8Direction.Direction8()) {
                case Direction.N:
                    _animator.Play(RunN);
                    break;
                case Direction.NE:
                    _animator.Play(RunNE);
                    break;
                case Direction.E:
                    _animator.Play(RunE);
                    break;
                case Direction.SE:
                    _animator.Play(RunSE);
                    break;
                case Direction.S:
                    _animator.Play(RunS);
                    break;
                case Direction.SW:
                    _animator.Play(RunSW);
                    break;
                case Direction.W:
                    _animator.Play(RunW);
                    break;
                case Direction.NW:
                    _animator.Play(RunNW);
                    break;
            }
            _playerMovement.Move();
        }
    }
}
