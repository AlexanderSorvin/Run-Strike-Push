using UnityEngine;

namespace game
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerDynamics : MonoBehaviour
    {
        new Rigidbody rigidbody;
        [SerializeField] protected IController controller;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
            controller.StartControl();
        }

        public void FixedUpdate()
        {
            rigidbody.velocity = controller.GetСontrolAction() +
                GameManager.Instance.LevelSpeed * Vector3.forward;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.rigidbody?.GetComponent<IObjectType>()?
                .GetObjectType() == ETypeElement.DeadElement)
            {
                GameManager.Instance.deathEvent?.Invoke();
            }
        }
    }
}
