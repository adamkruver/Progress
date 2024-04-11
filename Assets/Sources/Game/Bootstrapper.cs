using Game.Sources.Game.Infrastructure.Loaders;
using UnityEngine;

namespace Game.Sources.Game
{
    public class Bootstrapper : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
                Load();
        }

        private void Load()
        {
            var loader = new Loader();

            var json = Resources.Load<TextAsset>("Save").text;
            var save = loader.Load(json);
        }
    }
}