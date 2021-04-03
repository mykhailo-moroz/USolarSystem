#if UNITY_EDITOR
using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

namespace SolarSystem.Editor
{
    [InitializeOnLoadAttribute]
    public static class EditorLanding
    {
        static EditorLanding()
        {
            EditorApplication.playModeStateChanged += InitApplication;
        }
        
        private static void InitApplication(PlayModeStateChange state)
        {
            Debug.Log(state);

            if (state == PlayModeStateChange.EnteredPlayMode)
            {
                var currentScene = SceneManager.GetActiveScene();

                if (currentScene.name != AppConfig.LandingSceneName)
                {
                    App.Init(() =>
                    {
                        Debug.Log("Application was initialized!");
                        App.State.Set(GameState.Game);
                
                        var sceneService = App.Services.Get<ISceneService>();
                        sceneService.Deactivate(currentScene.name, null);
                        sceneService.Load(currentScene.name, null);
                    });
                }
            }
        }
    }
}
#endif