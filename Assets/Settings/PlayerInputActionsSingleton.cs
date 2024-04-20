using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public static class PlayerInputActionsSingleton
    {
        // Singleton instance for the PlayerInputActions
        private static PlayerInputActions _playerInputActions;

        public static PlayerInputActions Instance {
            get {
                if (_playerInputActions == null) {
                    _playerInputActions = new PlayerInputActions();
                    _playerInputActions.Player.Enable();
                }
                return _playerInputActions;
            }
        }
    }
}
