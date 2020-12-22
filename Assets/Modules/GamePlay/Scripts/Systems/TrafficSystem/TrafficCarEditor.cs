using SolarSystem.Modules.GamePlay.Scripts.Configs;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.TrafficSystem
{
    [ExecuteInEditMode]
    internal class TrafficCarEditor : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.name = "TrafficCar";
            gameObject.tag = GameTags.TrafficCarTag;

            if (Application.isPlaying)
            {
                enabled = false;
            }
        }
    }
}