using UnityEngine;

namespace game
{
    public class MaterialObjectOptions : IMaterialObjectOptions
    {
        protected Renderer renderer;

        public MaterialObjectOptions(Renderer renderer, TypeElement typeElement = TypeElement.HelpElement, int numberStartZone = 0)
        {
            this.renderer = renderer;
            this.renderer.material = GameManager.Instance.GetCurrentLevelMaterials().GetMaterial(numberStartZone, typeElement);
        }

        public void SwapMaterial()
        {
            renderer.material = GameManager.Instance.GetCurrentLevelMaterials().SwapMaterial(renderer.material);
        }
    }
}
