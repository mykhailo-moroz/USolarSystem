using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;

namespace SolarSystem.Modules.GamePlay.Scripts
{
    public class GamePlayModule : ApplicationModule
    {
        public override void Load()
        {
            Bind<IInputService>().ToConstant(new InputService());
        }
    }
}