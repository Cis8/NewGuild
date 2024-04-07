using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild
{
    public class MainGameObjectRef : MonoBehaviour
    {
        [SerializeField] private GameObject _mainGameObject;

        /// <summary>
        /// Returns the root GameObject for the Entity. On such GameObject, the Entity's Game Logic components are attached.
        /// </summary>
        public GameObject MainGameObject { get => _mainGameObject; set => _mainGameObject = value; }
        


        void Start() {
        
        }

        void Update() {
        
        }
    }
}
