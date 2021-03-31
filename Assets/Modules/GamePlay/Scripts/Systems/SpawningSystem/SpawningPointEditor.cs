using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.SpawningSystem
{
    [ExecuteInEditMode]
    public class SpawningPointEditor : MonoBehaviour
    {
        private void Awake()
        {
            name = "Spawning Point";

            if (Application.isPlaying)
            {
                enabled = false;
            }
        }
    }
}