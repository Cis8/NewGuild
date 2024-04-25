using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerAnimation : MonoBehaviour
    {
        //[SerializeField] private PlayerState _playerState;

        [SerializeField]
        private Animator _animator;

        void Start() {
            
        }

        void Update() {
            //CheckIdleAnimation();
            //CheckRunAnimation();
        }

        /*private bool CheckRunAnimation() {
            if (_playerState.CurrentState == PlayerState.State.RunningN) {
                _animator.Play(RunN);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningNE) {
                _animator.Play(RunNE);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningE) {
                _animator.Play(RunE);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningSE) {
                _animator.Play(RunSE);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningS) {
                _animator.Play(RunS);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningSW) {
                _animator.Play(RunSW);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningW) {
                _animator.Play(RunW);
                return true;
            } else if (_playerState.CurrentState == PlayerState.State.RunningNW) {
                _animator.Play(RunNW);
                return true;
            }
            return false;
        }

        private bool CheckIdleAnimation() {
            if (_playerState.CurrentState == PlayerState.State.IdleN) {
                _animator.Play(IdleN);
            } else if (_playerState.CurrentState == PlayerState.State.IdleNE) {
                _animator.Play(IdleNE);
            } else if (_playerState.CurrentState == PlayerState.State.IdleE) {
                _animator.Play(IdleE);
            } else if (_playerState.CurrentState == PlayerState.State.IdleSE) {
                _animator.Play(IdleSE);
            } else if (_playerState.CurrentState == PlayerState.State.IdleS) {
                _animator.Play(IdleS);
            } else if (_playerState.CurrentState == PlayerState.State.IdleSW) {
                _animator.Play(IdleSW);
            } else if (_playerState.CurrentState == PlayerState.State.IdleW) {
                _animator.Play(IdleW);
            } else if (_playerState.CurrentState == PlayerState.State.IdleNW) {
                _animator.Play(IdleNW);
            }
            return false;
        }*/

        public void PlayAnimation() {

        }
    }
}
