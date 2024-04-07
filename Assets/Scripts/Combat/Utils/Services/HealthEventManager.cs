using System;
using UnityEngine;

namespace NewGuild.Combat
{
    public class HealthEventManager : IService {
        private event Action<GameObject> _onEntityDied;

        public virtual void SubscribeEntityDied(Action<GameObject> action) {
            _onEntityDied += action;
        }

        public virtual void UnsubscribeEntityDied(Action<GameObject> action) {
            _onEntityDied -= action;
        }

        public virtual void EntityDied(GameObject entity) {
            _onEntityDied?.Invoke(entity);
        }

        public delegate void HealthChanged(GameObject entity, int currentHealth, int previousHealth);

        private event HealthChanged _onEntityHealthChanged;

        public virtual void SubscribeEntityHealthChanged(HealthChanged deleg) {
            _onEntityHealthChanged += deleg;
        }

        public virtual void UnsubscribeEntityHealthChanged(HealthChanged deleg) {
            _onEntityHealthChanged -= deleg;
        }

        public virtual void EntityHealthChanged(GameObject entity, int currentHealth, int previousHealth) {
            _onEntityHealthChanged?.Invoke(entity, currentHealth, previousHealth);
        }
    }
}
