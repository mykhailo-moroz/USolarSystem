using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem
{
    public class ActorAnimationStateController : MonoBehaviour
    {
        [SerializeField]
        private Vector2 m_debugVelocity;

        private int m_velocityXHash;
        
        private Animator m_animator;
        private float m_velocityX = 0f;
        private float m_velocityZ = 0f;
        private float m_turningAngle = 0f;
        private float m_acceleration = 0.2f;
        private float m_decceleration = 0.5f;

        public void SetVelocity(float velocityX, float velocityZ)
        {
            m_velocityX = velocityX;
            m_velocityZ = velocityZ;
            
            //Debug.Log($"Velocity X: {m_velocityX}, Velocity Z: {m_velocityZ}");
        }

        public void SetTurningAngle(float angle)
        {
            m_turningAngle = Mathf.Round(angle);
        }
        
        private void Start()
        {
            m_animator = GetComponent<Animator>();
        }

        private void Update()
        {
            //Debug.Log($"Velocity X: {m_velocityX}, Velocity Z: {m_velocityZ}");
            
            m_animator.SetFloat("VelocityX", m_velocityX);
            m_animator.SetFloat("VelocityZ", m_velocityZ);
            m_animator.SetFloat("TurningAngle", m_turningAngle);
        }
    }
}