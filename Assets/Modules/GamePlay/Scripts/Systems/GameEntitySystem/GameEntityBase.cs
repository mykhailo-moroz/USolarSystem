using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.GameEntitySystem
{
    public class GameEntityBase : MonoBehaviour, IGameEntity
    {
        [SerializeField]
        private bool m_canBeDamaged = true;
        [SerializeField]
        private float m_health = 100;

        public bool CanBeDamaged => m_canBeDamaged;
        public float Health => m_health;
        public IGameEntityState<GameEntityState> State { get; }
    }
}