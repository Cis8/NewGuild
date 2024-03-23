using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        Vector3 _offset = new Vector3(-9.3f, 4.2f, -3.3f);

        public Vector3 Offset { get => _offset; set => _offset = value; }
        public Transform Target { get => _target; set => _target = value; }

        void Start() {
            
        }

        void Update() {
            transform.position = Target.position + Offset;
        
        }
    }
}
