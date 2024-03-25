using NewGuild.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class PlayerCollider : MonoBehaviour
    {
        [SerializeField] private Player _player;

        void Start() {
        
        }

        void Update() {
        
        }

        public bool CanMove(Vector3 direction) {
            float castRadius = 0.25f;
            float castDistance = _player.MovementSpeed * Time.deltaTime;
            bool canMove = !Physics2D.CircleCast(_player.transform.position, castRadius, _player.GetDirectionV3(), castDistance, LayerMask.GetMask("Environment"));
            return canMove;
        }

        public bool CanMoveX(Vector3 direction) {
            float castDistance = _player.MovementSpeed * Time.deltaTime + 0.03f; // 0.03f is the offset to check if the playerwould touch the wall
            // a smaller radius is used to prevent the player from getting stuck in the wall
            bool canMove = !Physics2D.CircleCast(_player.transform.position, 0.22f, new Vector3(direction.x, 0, 0), castDistance, LayerMask.GetMask("Environment"));
            return canMove;
        }

        public bool CanMoveY(Vector3 direction) {
            float castDistance = _player.MovementSpeed * Time.deltaTime + 0.03f; // 0.03f is the offset to check if the would touch the 
            // a smaller radius is used to prevent the player from getting stuck in the wall
            bool canMove = !Physics2D.CircleCast(_player.transform.position, 0.22f, new Vector3(0, direction.y, 0), castDistance, LayerMask.GetMask("Environment"));
            return canMove;
        }
    }
}
