using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.GameEntitySystem
{
    public interface IGameEntity
    {
        bool CanBeDamaged { get; }
        float Health { get; }
        IGameEntityState<GameEntityState> State { get; }
    }
}