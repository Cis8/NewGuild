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

        [SerializeField]
        private Animator _animator;

        public PlayerState PlayerState { get => _playerState; set => _playerState = value; }

        void Start() {
            
        }

        void Update() {
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

        public void PlayAnimation() {

        }
    }
}
