using UnityEngine;

namespace NewGuild.Combat.Utils
{
    public static class Utils
    {
        // Camera rotation to apply the isometric regulation on the inputs
        private static Vector3 _cameraRotation = new Vector3(0f, 0f, -28.114f);
        private static Matrix4x4 _cameraRotationMatrix = Matrix4x4.Rotate(Quaternion.Euler(_cameraRotation));
        public static Vector3 ToIso(this Vector3 input) => _cameraRotationMatrix.MultiplyPoint3x4(input);

        // Check if another entity is an opponent for the given one. It returns true if entities have different layers and if the other entity has a IDamageable component.
        // The IDamageable component is given as output through an out parameter
        public static bool IsDamageableOpponent(this GameObject self, GameObject other, out IDamageable damageable) {
            damageable = null;
            if (self.layer != other.layer) {
                if (GetMainGameObject(other).TryGetComponent(out damageable)) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// It returns the MainGameObject of the given GameObject. If the MainGameObjectRef component is not present, it throws an exception.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static GameObject GetMainGameObject(GameObject gameObject) {
            if (!gameObject.TryGetComponent(out MainGameObjectRef mainGameObjectRef)) {
                // if the component is not present, throw an exception
                throw new System.Exception($"MainGameObjectRef not found in {gameObject.name}. Add the MainGameObjectRef and bind the MainGameObject for such an object.");
            }
            return mainGameObjectRef.MainGameObject;
        }
        
    }
}
