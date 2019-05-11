using UnityEngine;
using UnityEditor;

namespace game
{
    public class PlayerObjectType : MonoBehaviour, IObjectType
    {
        public ETypeElement GetObjectType()
        {
            return ETypeElement.HelpElement;
        }
    }
}

