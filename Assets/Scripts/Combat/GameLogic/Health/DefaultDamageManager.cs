using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public class DefaultDamageManager : MonoBehaviour, IDamageable {
        [SerializeField] private HealthManager _healthManager;

        void Start() {
        
        }

        void Update() {
        
        }

        public void TakeDamage(IncomingDmg info) {
            _healthManager.SubtractHealth(info.IncomingAmount);
        }
    }
}
