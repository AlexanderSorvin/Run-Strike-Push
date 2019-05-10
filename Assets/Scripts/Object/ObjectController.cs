using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{

    public class ObjectController : MonoBehaviour
    {
        [SerializeField] protected TypeElement typeElement;

        protected MaterialObjectOptions materialOptions;

        private void Awake()
        {
            materialOptions = new MaterialObjectOptions(this, typeElement);
        }
    }
}
