using SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SolarSystem.Modules.GamePlay.Scripts.Configs
{
    [CreateAssetMenu(fileName = "Settings", menuName = "Game/Settings", order = 0)]
    internal class GameSettings : ScriptableObject
    {
        public Player Player;
        public Scene DefaultScene;
    }
}