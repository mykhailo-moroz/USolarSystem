using System;

namespace SolarSystem.Interfces
{
    public interface ISceneDelegate
    {
        void OnSceneLoaded();
        void OnSceneUnload();

        void ActivateScene(Action onComplete);
        void DeactivateScene(Action onComplete);
    }
}
