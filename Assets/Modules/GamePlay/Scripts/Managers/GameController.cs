using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    internal class GameController : MonoBehaviour, IGameController
    {
        private string m_gameplayModuleName = "GamePlay";
        
        private void Awake()
        {
            var module = new GamePlayModule();
            m_gameplayModuleName = module.Name;
            App.RegisterModule(module);

            var sceneService = App.Services.Get<ISceneService>();
            sceneService.Load(AppConfig.GamePlayUISceneName, manager =>
            {
                Debug.Log("Gameplay UI loaded");
            });
        }

        private void OnDestroy()
        {
            App.UnregisterModule(m_gameplayModuleName);
            var sceneService = App.Services.Get<ISceneService>();
            sceneService.Unload(AppConfig.GamePlayUISceneName, () =>
            {
                Debug.Log("Gameplay UI unloaded");
            });
        }
    }
}
