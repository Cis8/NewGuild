using NewGuild.Combat.Skills;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewGuild.Combat.Utils;


namespace NewGuild.Combat {
    public class WeaponController : MonoBehaviour {
        [SerializeField] private Skill _skill;
        [SerializeField] private Animator _animator;
        [SerializeField] private CollisionEvent _collider;

        private void Awake() {
            _skill.SetupSkill(gameObject, _animator);
        }

        void Start() { 

        }

        void Update() {

        }

        public void StartAttack() {
            _collider.gameObject.SetActive(true);
        }

        public void EndAttack() {
            _collider.gameObject.SetActive(false);
        }

        private void NotifySkillOfCollision(Collider2D other) {
            _skill.StartSkill(other.gameObject);
        }

        private void OnEnable() {
            _collider.OnTriggerEnter.AddListener(NotifySkillOfCollision);
        }
        private void OnDisable() {
            _collider.OnTriggerEnter.RemoveListener(NotifySkillOfCollision);
        }
    }
}
