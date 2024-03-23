using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField] private PlayerState _playerState;

        private static readonly int RunN = Animator.StringToHash("RunN");
        private static readonly int RunNE = Animator.StringToHash("RunNE");
        private static readonly int RunE = Animator.StringToHash("RunE");
        private static readonly int RunSE = Animator.StringToHash("RunSE");
        private static readonly int RunS = Animator.StringToHash("RunS");
        private static readonly int RunSW = Animator.StringToHash("RunSW");
        private static readonly int RunW = Animator.StringToHash("RunW");
        private static readonly int RunNW = Animator.StringToHash("RunNW");

        private static readonly int IdleN = Animator.StringToHash("IdleN");
        private static readonly int IdleNE = Animator.StringToHash("IdleNE");
        private static readonly int IdleE = Animator.StringToHash("IdleE");
        private static readonly int IdleSE = Animator.StringToHash("IdleSE");
        private static readonly int IdleS = Animator.StringToHash("IdleS");
        private static readonly int IdleSW = Animator.StringToHash("IdleSW");
        private static readonly int IdleW = Animator.StringToHash("IdleW");
        private static readonly int IdleNW = Animator.StringToHash("IdleNW");

        [SerializeField]
        private Animator _animator;

        public PlayerState PlayerState { get => _playerState; set => _playerState = value; }

        void Start() {
            
        }

        void Update() {
            CheckIdleAnimation();
            CheckRunAnimation();
        }

        private bool CheckRunAnimation() {
            if (PlayerState.CurrentState == PlayerState.State.RunningN) {
                _animator.Play(RunN);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningNE) {
                _animator.Play(RunNE);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningE) {
                _animator.Play(RunE);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningSE) {
                _animator.Play(RunSE);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningS) {
                _animator.Play(RunS);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningSW) {
                _animator.Play(RunSW);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningW) {
                _animator.Play(RunW);
                return true;
            } else if (PlayerState.CurrentState == PlayerState.State.RunningNW) {
                _animator.Play(RunNW);
                return true;
            }
            return false;
        }

        private bool CheckIdleAnimation() {
            if (PlayerState.CurrentState == PlayerState.State.IdleN) {
                _animator.Play(IdleN);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleNE) {
                _animator.Play(IdleNE);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleE) {
                _animator.Play(IdleE);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleSE) {
                _animator.Play(IdleSE);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleS) {
                _animator.Play(IdleS);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleSW) {
                _animator.Play(IdleSW);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleW) {
                _animator.Play(IdleW);
            } else if (PlayerState.CurrentState == PlayerState.State.IdleNW) {
                _animator.Play(IdleNW);
            }
            return false;
        }

        public void PlayAnimation() {

        }
    }
}
