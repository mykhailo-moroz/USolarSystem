using StansAssets.SceneManagement;

namespace SolarSystem.Modules.Core.Interfaces
{
    public interface ISceneService : ISceneLoadService
    {
        IScenePreloader Preloader { get; }
    }
}