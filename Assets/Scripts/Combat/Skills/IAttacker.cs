using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public interface IAttacker
    {
        public UnityAction<float> Attack { get; set; }
    }
}
