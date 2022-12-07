using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem
{
    public class Actor : MonoBehaviour,  IActor
    {
        public ActorState State { get; set; } = ActorState.Default;
    }
}