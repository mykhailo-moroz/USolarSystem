using SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem;

namespace SolarSystem.Modules.GamePlay.Scripts.Interfaces
{
    public interface IGameService
    {
        Player Player { get; }
        
        bool IsPlayerInited { get; }
        
        void InitPlayer();
    }
}