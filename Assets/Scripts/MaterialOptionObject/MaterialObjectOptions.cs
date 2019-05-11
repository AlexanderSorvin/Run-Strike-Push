using UnityEngine;

namespace game
{
    public class MaterialObjectOptions : MonoBehaviour, IMaterialObjectOptions
    {
        [SerializeField] protected new Renderer renderer;

        private void Awake()
        {
            var typeElement = GetComponent<IObjectType>();
            renderer.material = 
                GameManager.Instance.GetCurrentLevelMaterials().
                GetMaterial(
                    transform.parent?.GetComponent<IZone>()?.ZoneNumber ?? 0, 
                    typeElement.GetObjectType());
        }

        public void SwapMaterial()
        {
            renderer.material = GameManager.Instance.
                GetCurrentLevelMaterials().SwapMaterial(renderer.material);
        }
    }
}
