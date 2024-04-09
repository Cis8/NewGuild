using UnityEngine;

namespace NewGuild.Combat
{
    public interface IMover {
        public Vector3 GetMovementVector();

        public bool IsMoving() {
            return GetMovementVector().magnitude > 0;
        }
    }
}