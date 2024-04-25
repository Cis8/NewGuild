using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IState = NewGuild.Combat.SMachine.IState;

namespace NewGuild.Combat
{
    public abstract class BaseState : IState {
        protected readonly Entity8Direction _entity8Direction;
        protected readonly Animator _animator;

        protected BaseState(GameObject player, Animator animator) {
            if (!player.TryGetComponent(out _entity8Direction)) {
                var message = "Player does not have an Entity8Direction component";
                Debug.LogError(message);
                throw new System.Exception(message);
            }
            _animator = animator;
        }

        public abstract void FixedUpdate();

        public abstract void OnEnter();

        public abstract void OnExit();

        public abstract void Update();
    }
}
