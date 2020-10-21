using System;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Interfaces;
using StansAssets.SceneManagement;
using UnityEngine.Assertions;

namespace SolarSystem.Modules.Core.Infrastructure
{
    internal class DefaultSceneLoadService : SceneLoadService, ISceneService, IPreloadService
    {
        public IScenePreloader Preloader { get; private set; }

        public void PreparePreloader(Action onInit)
        {
            Load(AppConfig.DefaultPreloaderSceneName, sceneManager =>
            {
                Preloader = (IScenePreloader)sceneManager;
                Assert.IsNotNull(Preloader);

                onInit.Invoke();
            });
        }
    }
}