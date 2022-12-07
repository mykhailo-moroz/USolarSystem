using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem
{
    public interface IActor
    {
        ActorState State { get; set; }
    }
}