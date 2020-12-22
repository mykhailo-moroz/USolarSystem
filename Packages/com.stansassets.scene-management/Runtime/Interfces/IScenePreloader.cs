using System;

namespace SolarSystem.Interfces
{
    public interface IScenePreloader
    {
        void FadeIn(Action onComplete);
        void FadeOut(Action onComplete);

        void OnProgress(float progress);
    }
}
