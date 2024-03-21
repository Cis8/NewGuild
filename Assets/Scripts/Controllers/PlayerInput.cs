using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewGuild.Controllers
{
    public class PlayerInput : MonoBehaviour
    {
        void Start()
        {
        
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W)) {
                Debug.Log("W key was pressed");
            }
            if (Input.GetKeyDown(KeyCode.D)) {
                Debug.Log("D key was pressed");
            }
            if (Input.GetKeyDown(KeyCode.S)) {
                Debug.Log("S key was pressed");
            }
            if (Input.GetKeyDown(KeyCode.A)) {
                Debug.Log("A key was pressed");
            }
        }
    }
}
