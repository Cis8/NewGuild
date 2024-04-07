using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace NewGuild.Combat
{
    public class DefaultHealthManager : HealthManager {
        private HealthEventManager _healthEventManager;

        protected override void Awake() {
            base.Awake();
            _healthEventManager = ServiceLocator.Instance.Get<HealthEventManager>();
        }

        public override void SubtractHealth(int amount) {
            if (amount <= 0)
                return;
            var previousHealth = _health;
            _health -= amount;
            if (_health <= 0) {
                _health = 0;
                _healthEventManager.EntityDied(gameObject);
            }
            _healthEventManager.EntityHealthChanged(gameObject, _health, previousHealth);
        }

        public override void AddHealth(int amount) {
            if (amount <= 0)
                return;
            var previousHealth = _health;
            _health += amount;
            if (_health > MaxHealth) {
                _health = MaxHealth;
            }
            _healthEventManager.EntityHealthChanged(gameObject, _health, previousHealth);
        }
    }
}
