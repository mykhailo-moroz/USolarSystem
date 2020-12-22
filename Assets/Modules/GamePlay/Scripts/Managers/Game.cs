using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Configs;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;

#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    [RequireComponent(typeof(GameEditMode))]
    internal class Game : MonoBehaviour, IGameController
    {
        [SerializeField]
        private GameSettings m_gameSettings;
        private string m_gameplayModuleName = "GamePlay";
        
        private void Awake()
        {
#if UNITY_EDITOR
            if (m_gameSettings == null)
            {
                Debug.Log("Game settings is null, trying to load settings from file...");
                m_gameSettings = AssetDatabase.LoadAssetAtPath<GameSettings>("Assets/Modules/Gameplay/Settings/InGameSettings.asset");
                Debug.Log("Game settings is null, loaded game settings from file!");
            }  
#endif
            var module = new GamePlayModule(Camera.main, m_gameSettings);
            m_gameplayModuleName = module.Name;

            App.RegisterModule(module);

            var gameService = App.Services.Get<IGameService>();
            gameService.InitPlayer();

            var sceneService = App.Services.Get<ISceneService>();
            sceneService.Load(GameScenesConfig.InGameUISceneName, manager => { });
        }

        private void OnDestroy()
        {
            App.UnregisterModule(m_gameplayModuleName);
            
            var sceneService = App.Services.Get<ISceneService>();
            sceneService.Unload(GameScenesConfig.InGameUISceneName, () => { });
        }
    }
}
