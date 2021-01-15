using System;
using SolarSystem.Modules.Core.Static;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    internal class LevelController : MonoBehaviour, ILevelController
    {
        private string m_gameplayModuleName = "GamePlay";
        
        private void Awake()
        {
            var module = new GamePlayModule();
            //m_gameplayModuleName = module.Name;
            App.RegisterModule(module);
        }

        private void OnDestroy()
        {
            App.UnregisterModule(m_gameplayModuleName);
        }
    }
}
