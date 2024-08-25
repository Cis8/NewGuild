using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.Skills
{
    [CreateAssetMenu(fileName = "SwordAttack", menuName = "Skills/SwordAttack")]
    public class SwordAttack : Skill
    {
        private static readonly int SwordSlash = Animator.StringToHash("SwordSlash");

        public override void StartSkill(GameObject other = null) {
            _animator.Play(SwordSlash);
            DealDamage(other, new IncomingDmg(10));
        }

        void Start() {
        
        }

        void Update() {
        
        }
    }
}
