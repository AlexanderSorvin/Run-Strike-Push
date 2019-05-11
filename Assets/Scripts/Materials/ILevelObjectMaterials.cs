using UnityEngine;
using UnityEditor;

namespace game
{
    public interface ILevelObjectMaterials
    {
        /// <summary>
        /// Определяет материал, который должен быть у объекта
        /// Используется при инициализации объекта
        /// </summary>
        /// <param name="numberZone">Номер зоны, где находится объект</param>
        /// <param name="typeMaterial">Тип материала, который требуется инициализировать</param>
        /// <returns></returns>
        Material GetMaterial(int numberZone, ETypeElement typeMaterial);

        /// <summary>
        /// Изменить значение материала объекта на противоположный
        /// Используется при смене зон
        /// </summary>
        /// <param name="currentMaterial">Текущий материал объекта</param>
        /// <returns></returns>
        Material SwapMaterial(Material currentMaterial);
    }
}

