using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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

        /// <summary>
        /// Событие, происходящее при смерти персонажа
        /// </summary>
        public UnityEvent deathEvent;

        /// <summary>
        /// Запустить текущий уровень
        /// </summary>
        public void LoadLevel()
        {
            SceneManager.LoadScene((GameManager.Instance.CurrentLevel - 1) % SceneManager.sceneCountInBuildSettings);
        }
    }
}


