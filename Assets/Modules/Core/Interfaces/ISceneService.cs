using SolarSystem.Interfces;

namespace SolarSystem.Modules.Core.Interfaces
{
    public interface ISceneService : ISceneLoadService
    {
        IScenePreloader Preloader { get; }
    }
}