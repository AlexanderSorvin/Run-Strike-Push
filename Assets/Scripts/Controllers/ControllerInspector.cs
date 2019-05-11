using UnityEngine;
using System;

namespace game
{
    [Serializable]
    [CreateAssetMenu(fileName = "Player Controller Inspector", 
        menuName = "Scriptable Object/Player Controller Inspector")]
    public class ControllerInspector : IController
    {
        protected delegate Vector3 ControlAction();
        ControlAction controlAction = null;
        [SerializeField] float power;

        ControllerInspector()
        {
            StartControl();
        }

        public override Vector3 GetСontrolAction()
        {
            return controlAction?.Invoke() ?? Vector2.zero;
        }

        protected Vector3 GetControl()
        {
            Vector3 result = Vector2.zero;

            result += new Vector3(
                Input.GetKey(KeyCode.D) ? power : 0.0f, 
                0.0f,
                Input.GetKey(KeyCode.W) ? power : 0.0f);
            result -= new Vector3(
                Input.GetKey(KeyCode.A) ? power : 0.0f,
                0.0f,
                Input.GetKey(KeyCode.S) ? power : 0.0f);

            //Debug.Log(Input.GetKey(KeyCode.D) +
            //    " " + Input.GetKey(KeyCode.W) +
            //    " " + Input.GetKey(KeyCode.A) +
            //    " " + Input.GetKey(KeyCode.S));

            return result;
        }

        public override void StartControl()
        {
            controlAction = GetControl;
        }

        public override void StopControl()
        {
            controlAction = null;
        }
    }
}

