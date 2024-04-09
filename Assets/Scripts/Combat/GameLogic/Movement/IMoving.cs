using UnityEngine;

namespace NewGuild.Combat
{
    public interface IMoving {
        public Vector3 GetMovementVector();

        public bool IsMoving() {
            return GetMovementVector().magnitude > 0;
        }
    }
}