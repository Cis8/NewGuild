using NewGuild.Combat;
using NewGuild.Combat.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild
{
    public class ThornsDamage : MonoBehaviour
    {
        [SerializeField] private int _spikesDamage;
        [SerializeField] private float _cooldown;
        [SerializeField] private CollisionEvent _collisionEvent;
        private bool _spikesDmgOnCooldown = false;

        private void CheckThornsDamage(Collider2D other) {
            if (_spikesDmgOnCooldown) return;
            if (Utils.IsDamageableOpponent(gameObject, other.gameObject, out IDamageable dmgComponent)) {
                dmgComponent.TakeDamage(new IncomingDmg(_spikesDamage));
                _spikesDmgOnCooldown = true;
                StartCoroutine(RunFuncAfterTime(() => _spikesDmgOnCooldown = false, _cooldown));
            }
        }

        private IEnumerator RunFuncAfterTime(Action func, float time) {
            yield return new WaitForSecondsRealtime(_cooldown);
            func();
        }

        void Start() {
            
        }

        void Update() {
        
        }

        private void OnEnable() {
            _collisionEvent.OnTriggerStay.AddListener(CheckThornsDamage);
        }

        private void OnDisable() {
            _collisionEvent.OnTriggerStay.RemoveListener(CheckThornsDamage);
        }
    }
}
