using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Combat
{
    public interface I8Directioned
    {
        public enum Direction {
            N,
            NE,
            E,
            SE,
            S,
            SW,
            W,
            NW
        }
        Direction Direction8();
    }
}
