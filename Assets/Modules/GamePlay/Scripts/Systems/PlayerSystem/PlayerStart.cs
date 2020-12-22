using SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem.EditorModes;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem
{
    [RequireComponent(typeof(PlayerStartEditMode))]
    public class PlayerStart : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position, "player_start.png", true);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawIcon(transform.position, "player_start_selected.png", true);
        }
    }
}