using System;
using SolarSystem.Modules.Core.Services.Pooling;
using SolarSystem.Modules.GamePlay.Scripts.Configs;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.TrafficSystem
{
    [RequireComponent(typeof(TrafficCarEditor))]
    internal class TrafficCar : PoolableGameObject
    {
        private void Awake()
        {
            gameObject.layer = LayerMask.NameToLayer(GameLayers.TrafficCarLayer);
        }

        public override void Init(Action onRelease)
        {
            
        }

        public override void Release()
        {
            
        }
    }
}