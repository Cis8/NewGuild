using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public abstract class MovementHandler : MonoBehaviour, IMoving
    {
        protected virtual void Start() {
        
        }

        protected virtual void Update() {
        
        }

        public abstract Vector3 GetMovementVector();

        public bool IsMoving() {
            return GetMovementVector().magnitude > 0;
        }
    }
}
