using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{

    public class ObjectController : MonoBehaviour, IMaterialObjectOptions, IObjectType 
    {
        [SerializeField] protected TypeElement typeElement;

        /// <summary>
        /// Получить тип элемента
        /// </summary>
        /// <returns>Тип</returns>
        public TypeElement GetObjectType()
        {
            return typeElement;
        }

        /// <summary>
        /// Изменить материал на другой
        /// </summary>
        public void SwapMaterial()
        {
            materialOptions.SwapMaterial();
        }

        protected IMaterialObjectOptions materialOptions;

        private void Awake()
        {
            materialOptions = new MaterialObjectOptions(GetComponent<Renderer>(), typeElement, transform.parent.GetComponent<IZone>().ZoneNumber);
        }
    }
}
