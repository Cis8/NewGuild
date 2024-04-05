using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private CombatInput _combatInput;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private PlayerCollider _playerCollider;

        public float MovementSpeed { get => _movementSpeed; private set => _movementSpeed = value; }

        private void Awake() {
        }

        void Start()
        {
        
        }

        void Update()
        {
            if (_playerCollider.CanMove(_combatInput.GetMovementVector())) {
                Move(_combatInput.GetMovementVector());
            } else if (_playerCollider.CanMoveX(_combatInput.GetMovementVector())) {
                Move(new Vector3(_combatInput.GetMovementVector().x, 0, 0));
            } else if (_playerCollider.CanMoveY(_combatInput.GetMovementVector())) {
                Move(new Vector3(0, _combatInput.GetMovementVector().y, 0));
            }
        }

        private void Move(Vector3 movementVector) {
            transform.position += movementVector * Time.deltaTime * _movementSpeed;
        }

        public Vector3 GetDirectionV3() {
            return _combatInput.GetMovementVector();
        }
    }
}
