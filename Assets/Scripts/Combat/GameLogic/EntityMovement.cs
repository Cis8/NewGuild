using NewGuild.Combat;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class EntityMovement : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed;
        private IMovable _movementInput;
        [SerializeField] private EnvironmentCollision _playerEnvironmentCollision;


        public float MovementSpeed { get => _movementSpeed; private set => _movementSpeed = value; }

        private void Awake() {
            _movementInput = GetComponent<IMovable>();
        }

        void Start() {
        
        }

        void Update() {
            CheckMovement();
        }

        protected void CheckMovement() {
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
