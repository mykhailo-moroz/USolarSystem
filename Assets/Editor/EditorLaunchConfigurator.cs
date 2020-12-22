using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Static;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SolarSystem.Modules.GamePlay.Scripts.Editor
{
    [InitializeOnLoad]
    internal class EditorLaunchConfigurator
    {
        static EditorLaunchConfigurator() =>
            EditorApplication.playModeStateChanged += EditorApplicationOnplayModeStateChanged;

        private static void EditorApplicationOnplayModeStateChanged(PlayModeStateChange obj)
        {
            if (obj != PlayModeStateChange.EnteredPlayMode)
            {
                return;
            }
            
            var currentScene = SceneManager.GetActiveScene();

            if (currentScene.name == AppConfig.LandingSceneName)
            {
                return;
            }
            
            SceneManager.UnloadSceneAsync(currentScene.name);
                
            Debug.Log("Game started from editor!");
            App.Init(() =>
            {
                Debug.Log("Application initialized!");
                SceneManager.LoadScene(currentScene.name);
            });
        }
    }
}