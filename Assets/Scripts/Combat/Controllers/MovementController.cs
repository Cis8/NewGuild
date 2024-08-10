using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public abstract class MovementController : MonoBehaviour, IMover
    {
        public abstract UnityAction<Vector2> Move { get; set; }

        protected virtual void Start() {
        
        }

        protected virtual void Update() {
        
        }

        public abstract Vector3 GetMovementVectorIso();

        public abstract Vector3 GetMovementVectorRaw();
    }
}
