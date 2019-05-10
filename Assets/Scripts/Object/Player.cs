using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{
    public class Player : MonoBehaviour
    {

        protected MaterialObjectOptions materialOptions;

        private void Awake()
        {
            materialOptions = new MaterialObjectOptions(this);
        }
    }
}
