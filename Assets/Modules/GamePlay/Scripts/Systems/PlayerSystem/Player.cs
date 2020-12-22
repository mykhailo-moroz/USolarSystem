using System;
using SolarSystem.Modules.GamePlay.Scripts.Systems.GameEntitySystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem.EditorModes;
using SolarSystem.Modules.GamePlay.Scripts.Systems.VehicleSystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem
{
    [RequireComponent(typeof(PlayerEditMode))]
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_vehicleParent;
        [SerializeField]
        private Transform m_cameraParent;
        
        private Vehicle m_currentVehicle = default;
        private readonly Vector3 m_gizmosOffset = new Vector3(0, 3, 0);

        private void Awake()
        {
            if (m_vehicleParent != null)
            {
                m_currentVehicle = m_vehicleParent.GetComponentInChildren<Vehicle>();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position + m_gizmosOffset, "player_character.png", true);
        }
    }
}