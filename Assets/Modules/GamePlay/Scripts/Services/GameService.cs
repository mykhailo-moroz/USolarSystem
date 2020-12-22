using SolarSystem.Modules.GamePlay.Scripts.Configs;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using SolarSystem.Modules.GamePlay.Scripts.Static;
using SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Services
{
    internal class GameService : IGameService
    {
        private readonly GameSettings m_gameSettings;

        public GameService(GameSettings gameSettings)
        {
            m_gameSettings = gameSettings;
        }

        public Player Player { get; private set; }
        public bool IsPlayerInited => Player != null;

        public void InitPlayer()
        {
            var preInitPlayer = Object.FindObjectOfType<Player>();

            if (preInitPlayer != null)
            {
                Player = preInitPlayer;
                return;
            }
            
            if (!m_gameSettings.IsValid())
            {
                return;
            }
            var spawnPoint = Object.FindObjectOfType<PlayerStart>();

            if (spawnPoint == null)
            {
                return;
            }

            var playerObject = Object.Instantiate(m_gameSettings.Player.gameObject, spawnPoint.transform);
            Player = playerObject.GetComponent<Player>();
        }
        
        
    }
}