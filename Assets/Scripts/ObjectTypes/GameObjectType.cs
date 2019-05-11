using UnityEngine;
using UnityEditor;

namespace game
{
    public class GameObjectType : MonoBehaviour, IObjectType
    {
        /// <summary>
        /// Тип элемента
        /// </summary>
        [SerializeField] protected ETypeElement type;

        public ETypeElement GetObjectType()
        {
            return type;
        }
    }
}

