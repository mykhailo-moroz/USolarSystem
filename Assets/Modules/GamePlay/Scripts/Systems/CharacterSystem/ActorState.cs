using UnityEngine.Assertions.Must;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem
{
    public enum ActorState
    {
        Default = 0, 
        WeaponEquipped = 1,
        Interacting = 2,
        Dead = 3,
    }
}