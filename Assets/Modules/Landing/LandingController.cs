using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using UnityEngine;

namespace SolarSystem.Modules.Landing
{
    public class LandingController : MonoBehaviour
    {
        private void Start()
        {
            App.Init(() =>
            {
                App.State.Set(GameState.Menu);
                
                //var sceneService = App.Services.Get<ISceneService>();
                //sceneService.Unload(AppConfig.LandingSceneName, null);
            });
        }
    }    
}


