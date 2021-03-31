using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem
{
    public class Actor : MonoBehaviour,  IActor
    {
        [SerializeField]
        private int m_Affiliation;
        [SerializeField]
        private Transform m_aimPoint;

        public int Affiliation => m_Affiliation;

        public Transform AimPoint
        {
            get { return m_aimPoint; }
            set { m_aimPoint = value; }
        }
    }
}