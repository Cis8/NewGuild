using NewGuild.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class EntityMovement : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed;
        private IMoving _movementInput;
        [SerializeField] private EnvironmentCollision _playerEnvironmentCollision;


        public float MovementSpeed { get => _movementSpeed; private set => _movementSpeed = value; }

        private void Awake() {
            if (!TryGetComponent(out _movementInput)) {
                Debug.LogError("No IMovable component found on " + gameObject.name);
            }
        }

        void Start() {
        
        }

        void Update() {
            CheckMovement();
        }

        protected void CheckMovement() {
            // TODO improve this so that the Player state is interrogated to determing if the player can acttually move
            // (for example if it is stunned or is performing a blocking attack it should not be able to move)
            if (_playerEnvironmentCollision.CanMove(_movementInput.GetMovementVector())) {
                Move(_movementInput.GetMovementVector());
            } else if (_playerEnvironmentCollision.CanMoveX(_movementInput.GetMovementVector())) {
                Move(new Vector3(_movementInput.GetMovementVector().x, 0, 0));
            } else if (_playerEnvironmentCollision.CanMoveY(_movementInput.GetMovementVector())) {
                Move(new Vector3(0, _movementInput.GetMovementVector().y, 0));
            }
        }

        protected void Move(Vector3 movementVector) {
            transform.position += movementVector * Time.deltaTime * MovementSpeed;
        }

        public Vector3 GetDirectionV3() {
            return _movementInput.GetMovementVector();
        }
    }
}
