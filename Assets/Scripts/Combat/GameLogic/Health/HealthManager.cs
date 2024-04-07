using NewGuild.Combat;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public abstract class HealthManager : MonoBehaviour, IHealth {
        [SerializeField] protected int _maxHealth;

        protected int _health;

        protected virtual void Awake() {
            _health = _maxHealth;
        }

        public int MaxHealth { get => _maxHealth; private set => _maxHealth = value; }

        public int Health { get => _health; private set => _health = value; }

        public abstract void AddHealth(int amount);

        public abstract void SubtractHealth(int amount);

        void IHealth.AddHealth(int amount) {
            throw new NotImplementedException();
        }

        void IHealth.SubtractHealth(int amount) {
            throw new NotImplementedException();
        }
    }
}
