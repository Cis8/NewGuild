using NewGuild.Combat.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace NewGuild.Combat
{
    public class PlayerMovementInputController : MovementController
    {
        [SerializeField] private InputReader _inputReader;

        protected override void Start() {
            base.Start();
        }

        public override UnityAction<Vector2> Move { get => _inputReader.Move; set => _inputReader.Move = value; }

        public override Vector3 GetMovementVectorRaw() {
            return _inputReader.GetMovementVector();
        }

        public override Vector3 GetMovementVectorIso() {
            var inputVector = _inputReader.GetMovementVector();
            return new Vector3(inputVector.x, inputVector.y, 0).ToIso();
        }
    }
}
