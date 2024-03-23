using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Utils
{
    public static class Utils
    {
        // Camera rotation to apply the isometric regulation on the inputs
        private static float _cameraRotation = 28.114f;
        private static Matrix4x4 _cameraRotationMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, _cameraRotation, 0));
        public static Vector3 ToIso(this Vector3 input) => _cameraRotationMatrix.MultiplyPoint3x4(input);
    }
}
