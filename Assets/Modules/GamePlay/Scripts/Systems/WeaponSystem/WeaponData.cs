using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem
{
    [Serializable]
    public class WeaponData
    {
        [Header("Info")]
        public string Name;
        public string Description;
        public WeaponRarity Quality;
        public WeaponType WeaponType;
        
        [Header("Base Stats")]
        public float Damage;
        public float RateOfFire;
        public float ShootSpeed;
        public float Impact;
        public float Range;
        public float ReloadTime;
        public float ChargeRate;
        public int Inventory;
    }
}