using UnityEngine;
using SolarSystem.Modules.GamePlay.Scripts.Static;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.SpawningSystem
{
    [RequireComponent(typeof(SpawningPointEditor))]
    public class SpawningPoint : MonoBehaviour, ISpawningPoint
    {
        private float _yGizmosOffset = 1f;
        
        private void OnDrawGizmos()
        {
            Gizmos.DrawIcon(CalculateGizmosIconPos(), "gamepad_icon.png", true);
            GizmosDrawingHelper.DrawWireCapsule(CalculateGizmosIconPos(), transform.rotation, 0.5f, 2f, Color.cyan);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawIcon(CalculateGizmosIconPos(), "gamepad_icon.png", true);
            GizmosDrawingHelper.DrawWireCapsule(CalculateGizmosIconPos(), transform.rotation, 0.5f, 2f, Color.green);
        }

        private Vector3 CalculateGizmosIconPos()
        {
            var currentPos = transform.position;
            currentPos.y += _yGizmosOffset;

            return currentPos;
        }
    }
}