using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public interface IMover {
        public Vector3 GetMovementVectorIso();

        public UnityAction<Vector2> Move { get; set; }
    }
}