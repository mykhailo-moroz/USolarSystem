using SolarSystem.Modules.Core.Abstract;

namespace SolarSystem.Modules.Core
{
    internal sealed class CoreModule : ApplicationModule
    {
        public override void Load()
        {
            //Bind<ISceneService, IPreloadService>().To<DefaultSceneLoadService>().InSingletonScope();
            //Bind<IPoolingService>().ToConstant(new GameObjectsPool("GameObjects Pool"));
        }
    }
}