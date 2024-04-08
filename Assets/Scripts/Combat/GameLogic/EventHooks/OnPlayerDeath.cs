using NewGuild.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild
{
    // TODO This script can be made more generic. For example, it could become OnEntityDeath and be used for all entities.
    // It could also be composed by a set of generic functionalities such as: SpawnLoot, SpawnGO, ShowPopup, etc.
    public class OnPlayerDeath : MonoBehaviour
    {
        [SerializeField] private Transform _corpse;
        private HealthEventManager _healthEventManager;

        private void Awake() {
            _healthEventManager = ServiceLocator.Instance.Get<HealthEventManager>();
        }

        private void OnEnable() {
            _healthEventManager.SubscribeEntityDied(HandleDeath);
        }

        private void OnDisable() {
            _healthEventManager.UnsubscribeEntityDied(HandleDeath);
        }

        void Start() {
        
        }

        void Update() {
        
        }

        private void HandleDeath(GameObject entity) {
            if (entity == gameObject) {
                Instantiate(_corpse, transform.position, transform.rotation, transform.parent);
                Destroy(gameObject);
            }
        }
    }
}
