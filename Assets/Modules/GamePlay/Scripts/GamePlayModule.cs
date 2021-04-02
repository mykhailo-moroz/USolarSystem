using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.GamePlay.Scripts.Systems.CameraSystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts
{
    public class GamePlayModule : ApplicationModule
    {
        private Camera m_cameraMain;
        
        public GamePlayModule(Camera cameraMain)
        {
            m_cameraMain = cameraMain;
        }
        
        public override void Load()
        {
            Bind<IInputService>().ToConstant(new InputService());
            Bind<ICameraService>().ToConstant(new CameraService(m_cameraMain));
        }
    }
}