using SolarSystem.Modules.GamePlay.Scripts.Systems.TrafficSystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Interfaces
{
    public interface IPathFollower
    {
        void StartMoving();
        void StopMoving();
        void SetPathOffset(Vector3 offset);
        void SetPath(PathCreator.Runtime.Objects.PathCreator pathCreator);
        void SetDirection(TrafficMovingCarDirection carDirection);
        void SetMovementSpeed(float speed);
    }
}