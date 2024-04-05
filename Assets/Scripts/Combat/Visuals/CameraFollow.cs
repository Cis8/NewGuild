using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        Vector3 _offset = new Vector3(-2.1f, -4.25f, -3.263f);

        void Start() {
            
        }

        void Update() {
            transform.position = _target.position + _offset;
        
        }
    }
}
