using System;
using MikeAssets.ModularServiceLocator.Runtime;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;
using StansAssets.SceneManagement;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    internal class GameController : MonoBehaviour, IGameController, ISceneManager , ISceneDelegate
    {
        [SerializeField]
        private GameObject m_playerCharacter;
        private InputReceiver m_inputReceiver;
        
        private string m_gameplayModuleName = "GamePlay";

        public void OnSceneLoaded()
        {
            try
            {
                var module = new GamePlayModule(Camera.main);
                m_gameplayModuleName = module.Name;
                App.RegisterModule(module);

                m_inputReceiver = GetComponent<InputReceiver>();
                m_playerCharacter.SetActive(true);
                var sceneService = App.Services.Get<ISceneService>();
                sceneService.Load(AppConfig.GamePlayUISceneName, manager =>
                {
                    m_inputReceiver.LockInput(false);
                    Debug.Log("Gameplay UI loaded");
                });
            }
            catch (Exception e)
            {
                Debug.Log("Application or some of it's parts was not inited!");
            }
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
