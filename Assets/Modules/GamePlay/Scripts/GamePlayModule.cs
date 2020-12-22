using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.GamePlay.Scripts.Configs;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using SolarSystem.Modules.GamePlay.Scripts.Services;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts
{
    internal class GamePlayModule : ApplicationModule
    {
        private readonly Camera m_mainCamera;
        private readonly GameSettings m_gameSettings;
        
        public GamePlayModule(Camera mainCamera, GameSettings gameSettings)
        {
            m_mainCamera = mainCamera;
            m_gameSettings = gameSettings;
        }
        
        public override void Load()
        {
            Bind<ICameraService>().ToConstant(new CameraService(m_mainCamera));
            Bind<IGameService>().ToConstant(new GameService(m_gameSettings));
        }
    }
}