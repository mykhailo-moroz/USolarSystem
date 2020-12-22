using SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem;
using UnityEditor;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Editor
{
    public static class GameConfigurationMenu
    {
        [MenuItem("Game/Add Player Start", false, 1)]
        public static void AddPlayerStart()
        {
            var startPoint = new GameObject("Player Start");
            startPoint.AddComponent<PlayerStart>();
        }
    }
}