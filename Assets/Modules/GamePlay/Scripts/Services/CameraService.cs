using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Services
{
    internal class CameraService : ICameraService
    {
        public Camera MainCamera { get; private set; }

        public CameraService(Camera mainCamera)
        {
            MainCamera = mainCamera;
        }
    }
}