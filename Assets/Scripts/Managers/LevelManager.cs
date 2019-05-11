using UnityEngine;
using System.Collections;

namespace game
{
    public class LevelManager : Singleton<LevelManager>
    {
        [SerializeField] Zone[] gameZones;

        private void Awake()
        {
            for (int i = 0; i < gameZones.Length; i++)
            {
                gameZones[i].ZoneNumber = i;
            }
        }
    }
}


