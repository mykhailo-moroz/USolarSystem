using System.Collections.Generic;
using SolarSystem.Modules.Core.Services.Pooling;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.TrafficSystem
{
    internal class TrafficSpawner : MonoBehaviour
    {
        [SerializeField]
        private PathCreator.Runtime.Objects.PathCreator m_pathCreator;
        [SerializeField]
        private List<TrafficCar> m_cars = new List<TrafficCar>();
        [SerializeField]
        private TrafficMovingCarDirection m_carDirection = TrafficMovingCarDirection.Forward;

        private IPoolingService m_poolingService;
        private Vector3 m_spawningOffset;

        private void Awake()
        {
            var position = transform.position;
            var closestDistanceOnPath = m_pathCreator.path.GetClosestDistanceAlongPath(position);
            var closestPointOnPath = m_pathCreator.path.GetPointAtDistance(closestDistanceOnPath);

            m_spawningOffset = position - closestPointOnPath;

            m_poolingService = App.Services.Get<IPoolingService>();
        }

        [ContextMenu("Spawn Car")]
        public void Spawn()
        {
            SpawnCar();
        }
        
        private void SpawnCar()
        {
            var randomCar = GetRandomTrafficCar();
            var spawnedCar = m_poolingService.Instantiate<TrafficCar>(randomCar.gameObject);
            
            var spawnedCarGameObject = spawnedCar.gameObject;
            var pathFollower = spawnedCar.GetComponent<IPathFollower>();
            
            pathFollower?.SetDirection(m_carDirection);
            pathFollower?.SetMovementSpeed(Random.Range(5, 15));
            pathFollower?.SetPath(m_pathCreator);
            pathFollower?.SetPathOffset(m_spawningOffset);
            spawnedCarGameObject.transform.SetParent(gameObject.transform);
            pathFollower?.StartMoving();
        }

        private TrafficCar GetRandomTrafficCar()
        {
            var randomIndex = Random.Range(0, m_cars.Count);
            var randomCar = m_cars[randomIndex];

            return randomCar;
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position, "trafficSpawner.png", true);
        }
    }
}