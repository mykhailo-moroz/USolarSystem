using System;

namespace SolarSystem.Modules.Core.Interfaces
{
    internal interface IPreloadService
    {
        void PreparePreloader(Action onInit);
    }
}