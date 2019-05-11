using System.Collections;
using UnityEngine;

namespace game
{

    [CreateAssetMenu(fileName = "Level Materials", menuName = "Scriptable Object/Level Materials")]
    public class LevelMaterials : ScriptableObject
    {
        /// <summary>
        /// Первый материал, который используется в игре
        /// </summary>
        [SerializeField] protected Material material1;
        /// <summary>
        /// Второй материал, который используется в игре
        /// </summary>
        [SerializeField] protected Material material2;
        /// <summary>
        /// Материал зоны
        /// </summary>
        [SerializeField] protected Material materialZone;

        /// <summary>
        /// Массив из полученных материалов
        /// </summary>
        protected Material[] materials;

        private void OnEnable()
        {
            materials = new Material[2];
            materials[0] = material1;
            materials[1] = material2;
        }

        /// <summary>
        /// Определяет материал, который должен быть у объекта
        /// Используется при инициализации объекта
        /// </summary>
        /// <param name="numberZone">Номер зоны, где находится объект</param>
        /// <param name="typeMaterial">Тип материала, который требуется инициализировать</param>
        /// <returns></returns>
        public Material GetMaterial(int numberZone, TypeElement typeMaterial)
        {
            return materials[(numberZone + (int)typeMaterial) % 2];
        }

        /// <summary>
        /// Изменить значение материала объекта на противоположный
        /// Используется при смене зон
        /// </summary>
        /// <param name="currentMaterial">Текущий материал объекта</param>
        /// <returns></returns>
        public Material SwapMaterial(Material currentMaterial)
        {
            return (currentMaterial == material1) ? material2 : material1;
        }

        /// <summary>
        /// Получить материал зоны
        /// </summary>
        /// <returns></returns>
        public Material GetMaterialZone()
        {
            return materialZone;
        }
    }

}