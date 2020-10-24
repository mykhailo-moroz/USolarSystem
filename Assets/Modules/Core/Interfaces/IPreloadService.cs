using System;

namespace SolarSystem.Modules.Core.Interfaces
{
    internal interface IPreloadService : ISceneService
    {
        void PreparePreloader(Action onInit);
    }
}