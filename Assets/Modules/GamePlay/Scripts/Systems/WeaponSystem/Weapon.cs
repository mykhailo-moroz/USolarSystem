using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private bool m_isFiring = false;

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