using System;
using SolarSystem.Core;
using SolarSystem.Interfces;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Interfaces;
using UnityEngine.Assertions;

namespace SolarSystem.Modules.Core.Infrastructure
{
    internal class DefaultSceneLoadService : SceneLoadService, IPreloadService
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