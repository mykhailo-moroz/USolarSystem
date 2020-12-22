using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem
{
    internal class CameraFollow : MonoBehaviour
    {
        [SerializeField]
        private Transform m_target;
        private Vector3 m_offset;

        public void SetTarget(Transform target)
        {
            m_target = target;
        }
    }
}