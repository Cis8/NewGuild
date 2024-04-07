using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    /// <summary>
    /// Abstraction to represent incoming damage. Contains various information that can be used to calculate the effective final damage.
    /// </summary>
    public class IncomingDmg
    {
        private int _incomingAmount;

        public IncomingDmg(int incomingAmount) {
            IncomingAmount = incomingAmount;
        }

        public int IncomingAmount { get => _incomingAmount; private set => _incomingAmount = value; }
    }
}
