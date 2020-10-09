using SolarSystem.Modules.Core.Static;
using UnityEngine;

namespace SolarSystem.Modules.Landing
{
    public class LandingController : MonoBehaviour
    {
        private void Start()
        {
            GameServices.Init(Game.Init);
        }
    }    
}


