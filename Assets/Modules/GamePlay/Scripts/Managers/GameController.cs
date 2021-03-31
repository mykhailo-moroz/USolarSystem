using System;
using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using StansAssets.SceneManagement;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    internal class GameController : MonoBehaviour, IGameController, ISceneManager , ISceneDelegate
    {
        [SerializeField]
        private GameObject m_playerCharacter;
        private string m_gameplayModuleName = "GamePlay";

        public void OnSceneLoaded()
        {
            var module = new GamePlayModule();
            m_gameplayModuleName = module.Name;
            App.RegisterModule(module);
            
            m_playerCharacter.SetActive(true);
            var sceneService = App.Services.Get<ISceneService>();
            sceneService.Load(AppConfig.GamePlayUISceneName, manager =>
            {
                Debug.Log("Gameplay UI loaded");
            });
        }

        public void OnSceneUnload()
        {
            m_playerCharacter.SetActive(false);
            App.UnregisterModule(m_gameplayModuleName);
            var sceneService = App.Services.Get<ISceneService>();
            sceneService.Unload(AppConfig.GamePlayUISceneName, () =>
            {
                Debug.Log("Gameplay UI unloaded");
            });
        }

        public void ActivateScene(Action onComplete)
        {
        }

        public void DeactivateScene(Action onComplete)
        {
        }
    }
}
