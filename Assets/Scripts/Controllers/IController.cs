using UnityEngine;
using System;

namespace game
{
    [Serializable]
    public abstract class IController : ScriptableObject
    {
        /// <summary>
        /// Получить управление от кнопки
        /// </summary>
        /// <returns>Величина управления</returns>
        public abstract Vector3 GetСontrolAction();

        /// <summary>
        /// Отключить управление контролером
        /// </summary>
        public abstract void StopControl();

        /// <summary>
        /// Запустить управление контролером
        /// </summary>
        public abstract void StartControl();
    }
}
