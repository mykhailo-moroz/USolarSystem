using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.Core.Infrastructure;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Services.Pooling;

namespace SolarSystem.Modules.Core
{
    internal sealed class CoreModule : ApplicationModule
    {
        public override void Load()
        {
            Bind<ISceneService, IPreloadService>().ToConstant(new DefaultSceneLoadService());
            Bind<IPoolingService>().ToConstant(new GameObjectsPool("GameObjects Pool"));
        }
    }
}