﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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
        public HaskeyIntController CurrentLevel
        {
            get
            {
                return currentLevel;
            }
            protected set
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
        /// Получить текущие материалы данного уровня
        /// </summary>
        /// <returns>Материалы уровня</returns>
        public LevelMaterials GetCurrentLevelMaterials()
        {
            return levelMaterials[numberCurrentLevelMaterial];
        }

        /// <summary>
        /// Базовая скорость на уровнях
        /// </summary>
        [SerializeField] private float levelSpeed;

        /// <summary>
        /// Метод получения скорости на уровне
        /// </summary>
        public float LevelSpeed
        {
            get
            {
                return levelSpeed;
            }
        }

        private void Awake()
        {
            var objs = FindObjectsOfType<GameManager>();
            if (objs.Length > 1)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
                CurrentLevel = new HaskeyIntController("Level", 1);
            }
        }

        /// <summary>
        /// Назначить следующий уровень
        /// </summary>
        public void ChangeNewLevel()
        {
            CurrentLevel.Set(CurrentLevel + 1);
        }
    }

}
