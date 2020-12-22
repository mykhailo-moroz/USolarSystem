using SolarSystem.Modules.GamePlay.Scripts.Configs;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem.EditorModes
{
    [ExecuteInEditMode]
    internal class PlayerEditMode : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.name = "PlayerCharacter";
            gameObject.tag = GameTags.PlayerTag;
            
            if (Application.isPlaying)
            {
                enabled = false;
            }
        }
    }
}