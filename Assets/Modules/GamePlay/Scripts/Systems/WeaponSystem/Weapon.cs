using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private bool m_isFiring = false;
        [SerializeField]
        private WeaponData m_weaponData;

        public void SetWeaponData(WeaponData weaponData)
        {
            m_weaponData = weaponData;
        }
        
        public void StartFiring()
        {
            m_isFiring = true;
        }

        public void StopFiring()
        {
            m_isFiring = false;
        }
        
    }
}