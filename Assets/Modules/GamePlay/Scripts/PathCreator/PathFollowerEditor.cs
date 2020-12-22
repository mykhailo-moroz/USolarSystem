using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.PathCreator
{
    [ExecuteInEditMode]
    internal class PathFollowerEditor : MonoBehaviour
    {
        [SerializeField]
        private Runtime.Objects.PathCreator m_pathCreator;
        
        private void Awake()
        {
            if (Application.IsPlaying(this))
            {
                enabled = false;
            }
            
            if (m_pathCreator == null)
            {
                return;
            }

            var distance = m_pathCreator.path.GetClosestDistanceAlongPath(transform.position);
            transform.position = m_pathCreator.path.GetPointAtDistance(distance);
            transform.rotation = m_pathCreator.path.GetRotationAtDistance(distance);
        }
    }
}