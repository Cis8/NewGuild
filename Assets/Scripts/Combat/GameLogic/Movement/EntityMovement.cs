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
        [SerializeField] private EnvironmentCollision _entityEnvironmentCollision;
        private Timer _movementTimer;


        public float MovementSpeed { get => _movementSpeed; private set => _movementSpeed = value; }
        public Timer MovementTimer { get => _movementTimer; private set => _movementTimer = value; }

        private void Awake() {
            if (!TryGetComponent(out _movementController)) {
                var message = "No IMover component found on " + gameObject.name;
                Debug.LogError(message);
                throw new System.Exception(message);
            }
            _movementTimer = new StopwatchTimer();
            _movementController.Move += OnMove;
        }

        protected virtual void Start() {
        
        }

        protected virtual void Update() {
            _movementTimer.Tick(Time.deltaTime);
        }

        public Vector3 GetDirectionV3Raw() {
            return _movementController.GetMovementVectorRaw();
        }

        public Vector3 GetDirectionV3Iso() {
            return _movementController.GetMovementVectorIso();
        }

        // this method is called by the StateMachine to move the entity
        public virtual void Move() {
            // TODO improve this so that the Entity state is interrogated to determing if the player can actually move
            // (for example if it is stunned or is performing a blocking attack it should not be able to move)
            if (_entityEnvironmentCollision.CanMove(GetDirectionV3Iso())) {
                MoveEntity(_movementController.GetMovementVectorIso());
            } else if (_entityEnvironmentCollision.CanMoveX(GetDirectionV3Iso())) {
                MoveEntity(new Vector3(GetDirectionV3Iso().x, 0, 0));
            } else if (_entityEnvironmentCollision.CanMoveY(GetDirectionV3Iso())) {
                MoveEntity(new Vector3(0, GetDirectionV3Iso().y, 0));
            }
        }

        // Delegate for getting notified when the object expressed the intention to move
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
