using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public interface IDamageable
    {
        public void TakeDamage(IncomingDmg info);
    }
}
