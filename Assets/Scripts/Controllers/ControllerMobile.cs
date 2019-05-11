using System;
using UnityEngine;

namespace game
{
    [Serializable]
    [CreateAssetMenu(fileName = "Player Controller Mobile",
    menuName = "Scriptable Object/Player Controller Mobile")]
    public class ControllerMobile : IController
    {
        protected delegate Vector3 ControlAction();
        ControlAction controlAction = null;

        public override Vector3 GetСontrolAction()
        {
            return controlAction?.Invoke() ?? Vector3.zero;
        }

        protected Vector3 GetControl()
        {
            Vector3 result = Vector3.zero;

            for (var i = 0; i < Input.touchCount; i++)
            {
                result += new Vector3(
                    Input.GetTouch(i).deltaPosition.y, 
                    0.0f, 
                    Input.GetTouch(i).deltaPosition.x);
            }

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
