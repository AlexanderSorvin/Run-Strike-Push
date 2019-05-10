using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game
{

    public class GameManager : Singleton<GameManager>
    {

        /// <summary>
        /// Массив материалов
        /// </summary>
        [SerializeField] protected LevelMaterials[] levelMaterials;

        /// <summary>
        /// Текущий уровень
        /// </summary>
        private HaskeyIntController currentLevel;

        /// <summary>
        /// Текущий уровень
        /// </summary>
        protected HaskeyIntController CurrentLevel
        {
            get
            {
                return currentLevel;
            }
            set
            {
                currentLevel = value;
                numberCurrentLevelMaterial = Random.Range(0, levelMaterials.Length);
            }
        }

        /// <summary>
        /// Номер коллекции материалов, используемых на данном уровне
        /// </summary>
        protected int numberCurrentLevelMaterial = 0;

        /// <summary>
        /// Получить текущие материалы данного уровеня
        /// </summary>
        /// <returns>Материалы уровня</returns>
        public LevelMaterials GetCurrentLevelMaterials()
        {
            return levelMaterials[numberCurrentLevelMaterial];
        }

        private void Awake()
        {
            CurrentLevel = new HaskeyIntController("Level", 1);
        }
    }

}
