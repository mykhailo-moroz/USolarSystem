using SolarSystem.Modules.Core.Kernel.SceneLoading.Abstract;
using SolarSystem.Modules.Core.Kernel.SceneLoading.Inerfaces;

namespace SolarSystem.Modules.Core.Services
{
    public class DefaultSceneLoadService : SceneLoadService, ISceneLoadService
    {
        public IScenePreloader Preloader { get; private set; }

        public DefaultSceneLoadService()
        {
            
        }
    }
}