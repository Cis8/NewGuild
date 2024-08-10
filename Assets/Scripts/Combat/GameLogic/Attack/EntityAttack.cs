using NewGuild.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat {
    public class EntityAttack : MonoBehaviour, IAttacking {
        protected IAttacker _attackController;
        private Timer _attackTimer;

        public Timer AttackTimer { get => _attackTimer; set => _attackTimer = value; }

        private void Awake() {
            if (!TryGetComponent(out _attackController)) {
                var message = "No IAttacker component found on " + gameObject.name;
                Debug.LogError(message);
                throw new System.Exception(message);
            }
            _attackTimer = new StopwatchTimer();
            _attackController.Attack += OnAttack;
        }

        void Start() {

        }

        void Update() {
            _attackTimer.Tick(Time.deltaTime);
        }

        // This method is called by the StateMAchine to trigger the attack
        public void Attack() {
            Debug.Log("Attack!");
        }

        protected void OnAttack(float intentionToAttack) {
            // TODO add logic to determine if the attack can be executed
            if (intentionToAttack > 0f) {
                _attackTimer.Start();
            }
        }
    }
}
