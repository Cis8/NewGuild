using NewGuild.Combat;
using NewGuild.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class EntityMovement : MonoBehaviour, IMoving
    {
        [SerializeField] private float _movementSpeed;
        protected IMover _movementController;
        [SerializeField] private EnvironmentCollision _playerEnvironmentCollision;
        private Timer _movementTimer;


        public float MovementSpeed { get => _movementSpeed; private set => _movementSpeed = value; }
        public Timer MovementTimer { get => _movementTimer; private set => _movementTimer = value; }

        private void Awake() {
            _movementController.Move += OnMove;
        }

        protected virtual void Start() {
        
        }

        protected virtual void Update() {
            
        }

        public Vector3 GetDirectionV3() {
            return _movementController.GetMovementVectorIso();
        }

        // this method is called by the StateMachine to move the entity
        public virtual void Move() {
            // TODO improve this so that the Player state is interrogated to determing if the player can acttually move
            // (for example if it is stunned or is performing a blocking attack it should not be able to move)
            if (_playerEnvironmentCollision.CanMove(GetDirectionV3())) {
                MoveEntity(_movementController.GetMovementVectorIso());
            } else if (_playerEnvironmentCollision.CanMoveX(GetDirectionV3())) {
                MoveEntity(new Vector3(GetDirectionV3().x, 0, 0));
            } else if (_playerEnvironmentCollision.CanMoveY(GetDirectionV3())) {
                MoveEntity(new Vector3(0, GetDirectionV3().y, 0));
            }
        }

        // Delegate for getting notified when the object moves
        protected void OnMove(Vector2 direction) {
            if (direction != Vector2.zero && !_movementTimer.IsRunning) {
                _movementTimer.Start();
            } else if (direction == Vector2.zero && _movementTimer.IsRunning) {
                _movementTimer.Stop();
            }
        }

        private void MoveEntity(Vector3 movementVector) {
            transform.position += movementVector * Time.deltaTime * MovementSpeed;
        }
    }
}
