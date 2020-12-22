using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.VehicleSystem
{
    public class VehicleCollisionEventArgs : EventArgs
    {
        public VehicleCollisionEventArgs(Collision collision)
        {
            Collision = collision;
        }

        public Collision Collision { get; }
    }
}