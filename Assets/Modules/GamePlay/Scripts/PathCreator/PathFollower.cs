using System;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using SolarSystem.Modules.GamePlay.Scripts.Static;
using SolarSystem.Modules.GamePlay.Scripts.Systems.TrafficSystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.PathCreator
{
    internal class PathFollower : MonoBehaviour, IPathFollower
    {
        [SerializeField]
        private Runtime.Objects.PathCreator m_pathCreator;
        [SerializeField]
        private float m_speed = 5;
        [SerializeField]
        private float m_acceleration = 2;
        [SerializeField]
        private TrafficMovingCarDirection m_carDirection = TrafficMovingCarDirection.Forward;
        
        private Vector3 m_movementOffset = Vector3.zero;
        private float m_distanceTravelled;
        private float m_currentSpeed = 0f;
        private bool m_isStarted = false;

        private void Awake()
        {
            if (m_pathCreator == null)
            {
                return;
            }
            
            m_distanceTravelled = m_pathCreator.path.GetClosestDistanceAlongPath(transform.position);

            transform.position = m_movementOffset + m_pathCreator.path.GetPointAtDistance(m_distanceTravelled);
            transform.rotation = m_pathCreator.path.GetRotationAtDistance(m_distanceTravelled);
        }

        private void Update()
        {
            if (m_pathCreator == null)
            {
                return;
            }
            
            if (!m_isStarted && m_currentSpeed > 0)
            {
                m_currentSpeed -= Time.deltaTime * 2;
            }
            else if (!m_isStarted && m_currentSpeed <= 0)
            {
                m_currentSpeed = 0;
                return;
            }

            if (m_isStarted && m_currentSpeed < m_speed)
            {
                m_currentSpeed += Time.deltaTime * m_acceleration;
            }

            switch (m_carDirection)
            {
                case TrafficMovingCarDirection.Forward:
                    m_distanceTravelled += m_currentSpeed * Time.deltaTime;
                    transform.rotation = m_pathCreator.path.GetRotationAtDistance(m_distanceTravelled);
                    break;
                case TrafficMovingCarDirection.Backward:
                    m_distanceTravelled -= m_currentSpeed * Time.deltaTime;
                    transform.rotation = m_pathCreator.path.GetRotationAtDistance(m_distanceTravelled).FlipYDirection();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            transform.position = m_movementOffset + m_pathCreator.path.GetPointAtDistance(m_distanceTravelled);
            
        }

        public void SetPathOffset(Vector3 offset)
        {
            m_movementOffset = offset;
        }

        public void SetPath(Runtime.Objects.PathCreator pathCreator)
        {
            m_pathCreator = pathCreator;
        }

        public void SetDirection(TrafficMovingCarDirection carDirection)
        {
            if (m_carDirection != carDirection)
            {
                transform.rotation = transform.rotation.FlipYDirection();
                m_carDirection = carDirection;
            }
        }

        public void SetMovementSpeed(float speed)
        {
            m_speed = speed;
        }

        [ContextMenu("Start moving")]
        public void StartMoving()
        {
            m_isStarted = true;
        }

        [ContextMenu("Stop moving")]
        public void StopMoving()
        {
            m_isStarted = false;
        }
    }
}