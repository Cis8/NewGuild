using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private CombatInput _combatInput;
        [SerializeField] private float _movementSpeed;

        public CombatInput CombatInput { get => _combatInput; set => _combatInput = value; }
        public float MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }

        void Start()
        {
        
        }

        void Update()
        {           
            transform.position += CombatInput.GetMovementVector() * Time.deltaTime * MovementSpeed;
        }
    }
}
