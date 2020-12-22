using System;
using SolarSystem.Modules.GamePlay.Scripts.Systems.GameEntitySystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.VehicleSystem
{
    [RequireComponent(typeof(VehicleEditMode))]
    public class Vehicle : GameEntityBase
    {
        [SerializeField]
        private ParticleSystem[] m_engineParticles;
        [SerializeField]
        private AudioClip m_idleSound;
        [SerializeField]
        private AudioClip m_accelerationSound;
        
        private VehicleState m_state = VehicleState.Unknown;
        
        public event EventHandler<VehicleCollisionEventArgs> OnCollitionEvent;
        
        public VehicleState State => m_state;

        public void SetState(VehicleState vehicleState)
        {
            m_state = vehicleState;
        }

        private void OnCollisionEnter(Collision other)
        {
            OnCollitionEvent(this, new VehicleCollisionEventArgs(other));
        }

        private void OnCollisionExit(Collision other)
        {
            OnCollitionEvent(this, new VehicleCollisionEventArgs(other));
        }

        private void OnCollisionStay(Collision other)
        {
            OnCollitionEvent(this, new VehicleCollisionEventArgs(other));
        }
    }
}