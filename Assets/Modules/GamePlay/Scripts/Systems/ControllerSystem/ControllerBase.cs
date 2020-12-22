using SolarSystem.Modules.GamePlay.Scripts.Systems.GameEntitySystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.ControllerSystem
{
    public abstract class ControllerBase : MonoBehaviour
    {
        private GameEntityBase m_possessedEntity;
        
        public virtual void Possess(GameEntityBase entityBase)
        {
            m_possessedEntity = entityBase;
        }

        public virtual void UnPossess()
        {
            m_possessedEntity = null;
        }
    }
}