using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Managers
{
    [ExecuteInEditMode]
    internal class GameEditMode : MonoBehaviour
    {
        private void Awake()
        {
            gameObject.name = "Game Play Controller";
            
            if (Application.isPlaying)
            {
                enabled = false;
            }
        }
    }
}