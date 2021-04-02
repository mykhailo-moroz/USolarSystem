using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CameraSystem
{ 
    public class CameraService : ICameraService
    {
        public CameraService(Camera mainCamera)
        {
            MainCamera = mainCamera;
        }

        public Camera MainCamera { get; }
    }
}