using SolarSystem.Modules.GamePlay.Scripts.Configs;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem.EditorModes
{
    [ExecuteInEditMode]
    internal class PlayerStartEditMode : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.name = "PlayerStart";
            gameObject.tag = GameTags.PlayerStartTag;
            
            if (Application.isPlaying)
            {
                enabled = false;
            }
        }
    }
}