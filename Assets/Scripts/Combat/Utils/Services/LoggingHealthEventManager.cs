using NewGuild.Combat;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild
{
    public class LoggingHealthEventManager : HealthEventManager {
        public override void SubscribeEntityDied(Action<GameObject> action) {
            Debug.Log($"Subscribed to entity died event");
            base.SubscribeEntityDied(action);
        }

        public override void UnsubscribeEntityDied(Action<GameObject> action) {
            Debug.Log($"Unsubscribed from entity died event");
            base.UnsubscribeEntityDied(action);
        }

        public override void EntityDied(GameObject entity) {
            Debug.Log($"{entity.name} died");
            base.EntityDied(entity);
        }

        public override void SubscribeEntityHealthChanged(HealthChanged deleg) {
            Debug.Log($"Subscribed to entity health changed event");
            base.SubscribeEntityHealthChanged(deleg);
        }

        public override void UnsubscribeEntityHealthChanged(HealthChanged deleg) {
            Debug.Log($"Unsubscribed from entity health changed event");
            base.UnsubscribeEntityHealthChanged(deleg);
        }

        public override void EntityHealthChanged(GameObject entity, int currentHealth, int previousHealth) {
            Debug.Log($"{entity.name} health changed from {previousHealth} to {currentHealth}");
            base.EntityHealthChanged(entity, currentHealth, previousHealth);
        }
    }
}
