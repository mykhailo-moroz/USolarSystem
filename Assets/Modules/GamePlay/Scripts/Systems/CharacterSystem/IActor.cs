using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem
{
    public interface IActor
    {
        int Affiliation { get; }
        Transform AimPoint { get; set; }
    }
}