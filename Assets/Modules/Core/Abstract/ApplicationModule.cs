using MikeAssets.ModularServiceLocator;

namespace SolarSystem.Modules.Core.Abstract
{
    public abstract class ApplicationModule : LocatorModule
    {
        public abstract override void Load();
    }
}