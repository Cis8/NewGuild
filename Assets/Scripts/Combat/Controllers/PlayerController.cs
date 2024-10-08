using NewGuild.Combat.SMachine;
using NewGuild.Combat.SMachine.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _playerMovement;
        [SerializeField] private EntityAttack _playerAttack;
        [SerializeField] private Animator _animator;

        private StateMachine _stateMachine;

        void At(IState from, IState to, IPredicate condition) => _stateMachine.AddTransition(from, to, condition);
        void Any(IState to, IPredicate condition) => _stateMachine.AddAnyTransition(to, condition);

        private bool ReturnToIdle() {
            return _stateMachine.GetState().GetType() != typeof(IdleState) && !_playerMovement.MovementTimer.IsRunning;
        }

        private void SetupStateMachine() {
            _stateMachine = new StateMachine();


            var idleState = new IdleState(gameObject, _animator);
            var moveState = new MoveState(gameObject, _animator);
            var attackState = new AttackState(gameObject, _animator);
            
            // Define transitions
            At(idleState, moveState, new FuncPredicate(() => _playerMovement.MovementTimer.IsRunning));
            At(idleState, attackState, new FuncPredicate(() => _playerAttack.AttackTimer.IsRunning));
            At(moveState, attackState, new FuncPredicate(() => _playerAttack.AttackTimer.IsRunning));
            Any(idleState, new FuncPredicate(ReturnToIdle));

            _stateMachine.SetState(idleState);
        }

        private void Awake() {
            SetupStateMachine();
        }

        void Start() {

        }

        void Update() {
            _stateMachine.Update();
        }
    }
}
