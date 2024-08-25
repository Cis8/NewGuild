using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public class CollisionEvent : MonoBehaviour
    {
        private UnityEvent<Collider2D> _onTriggerEnter = new UnityEvent<Collider2D>();

        public UnityEvent<Collider2D> OnTriggerEnter { get => _onTriggerEnter; private set => _onTriggerEnter = value; }

        private UnityEvent<Collider2D> _onTriggerStay = new UnityEvent<Collider2D>();

        public UnityEvent<Collider2D> OnTriggerStay { get => _onTriggerStay; private set => _onTriggerStay = value; }

        private void OnTriggerStay2D(Collider2D collision) {
            _onTriggerStay?.Invoke(collision);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            _onTriggerEnter?.Invoke(collision);
        }

        void Start() {
        
        }

        void Update() {
        
        }
    }
}
