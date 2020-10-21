using System;
using SolarSystem.Modules.Core.Static;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    internal class LevelController : MonoBehaviour, ILevelController
    {
        private void Awake()
        {
            App.RegisterModule(new GamePlayModule());
        }
    }
}
