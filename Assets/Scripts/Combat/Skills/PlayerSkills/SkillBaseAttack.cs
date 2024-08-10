using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat.Skills
{
    public class SkillBaseAttack : Skill
    {
        public override void StartSkill(GameObject other = null) {
            DealDamage(other, new IncomingDmg(10));
        }

        void Start() {
        
        }

        void Update() {
        
        }
    }
}
