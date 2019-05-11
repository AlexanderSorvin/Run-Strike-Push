using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{
    [RequireComponent(typeof(Rigidbody))]
    public class CameraDynamics : MonoBehaviour
    {
        new Rigidbody rigidbody;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            rigidbody.velocity = GameManager.Instance.LevelSpeed * Vector3.forward;
        }
    }
}
