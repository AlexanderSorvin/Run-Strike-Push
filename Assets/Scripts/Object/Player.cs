using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace game
{
    public class Player : MonoBehaviour
    {

        [SerializeField] protected new Renderer renderer;
        protected IMaterialObjectOptions materialOptions;
        protected 

        private void Awake()
        {
            materialOptions = new MaterialObjectOptions(renderer);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.rigidbody?.GetComponent<IObjectType>()?.GetObjectType() == TypeElement.DeadElement)
            {
                GameManager.Instance.deathEvent?.Invoke();
            }
        }
    }
}
