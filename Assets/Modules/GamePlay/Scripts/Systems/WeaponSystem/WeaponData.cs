using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem
{
    [Serializable]
    public class WeaponData
    {
        [Header("Base Stats")]
        public float Damage;
        public float RateOfFire;
        public float ShootSpeed;
        public float Impact;
        public float Range;
        public float ReloadTime;
        public float ChargeRate;
        public float BlastRadius;
        public float Velocity;
        public int Inventory;
        
        [Header("Info")]
        public string Name;
        public string Description;
        public int Quality;
        public WeaponType WeaponType;
    }
}