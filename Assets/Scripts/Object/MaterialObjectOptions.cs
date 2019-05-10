using UnityEngine;

namespace game
{
    public class MaterialObjectOptions
    {
        protected Renderer renderer;

        public MaterialObjectOptions(MonoBehaviour parent, TypeElement typeElement = TypeElement.HelpElement)
        {
            renderer = parent.GetComponent<Renderer>();
            renderer.material = GameManager.Instance.GetCurrentLevelMaterials().GetMaterial(0, typeElement);
        }

        public void SwapMaterial()
        {
            renderer.material = GameManager.Instance.GetCurrentLevelMaterials().SwapMaterial(renderer.material);
        }
    }
}
