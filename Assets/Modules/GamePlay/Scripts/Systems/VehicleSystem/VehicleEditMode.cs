using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.VehicleSystem
{
    [ExecuteInEditMode]
    internal class VehicleEditMode : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.name = "Vehicle";
            
            var rigidBody = GetComponentInChildren<Rigidbody>();
            rigidBody.isKinematic = true;

            var vehicleCollider = GetComponentInChildren<Collider>();
            vehicleCollider.isTrigger = true;

            if (Application.isPlaying)
            {
                enabled = false;
            }
        }
    }
}