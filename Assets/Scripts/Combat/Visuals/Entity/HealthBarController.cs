using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NewGuild.Combat
{
    public class HealthBarController : MonoBehaviour
    {
        [SerializeField] Slider _healthBar;
        [SerializeField] HealthManager _health;
        private HealthEventManager _healthEventManager;

        private void Awake() {
            _healthEventManager = ServiceLocator.Instance.Get<HealthEventManager>();
        }

        private void OnEnable() {
            _healthEventManager.SubscribeEntityHealthChanged(SetHealth);
        }

        private void OnDisable() {
            _healthEventManager.UnsubscribeEntityHealthChanged(SetHealth);
        }

        void Start() {
            _healthBar.maxValue = _health.MaxHealth;
            _healthBar.value = _health.Health;
        }

        void Update() {
        
        }

        private void SetHealth(GameObject entity, int currentHealth, int _) {
            if (entity == gameObject) {
                _healthBar.value = currentHealth;
            }
        }
    }
}
