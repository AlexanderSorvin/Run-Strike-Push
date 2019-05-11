using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{
    public class Zone : MonoBehaviour, IZone
    {
        [SerializeField] protected new Renderer renderer;

        /// <summary>
        /// Определить или задать номер зоны
        /// </summary>
        public int ZoneNumber { get; set; }

        private void Awake()
        {
            renderer.material = GameManager.Instance.GetCurrentLevelMaterials().GetMaterialZone();
        }
    }
}

