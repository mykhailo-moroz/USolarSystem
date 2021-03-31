using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class InputReceiver : MonoBehaviour
    {
        private IInputService m_inputService;

        private void Start()
        {
            m_inputService = App.Services.Get<IInputService>();
        }

        private void Update()
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            var verticalInput = Input.GetAxis("Vertical");

            var inputVector = new Vector2(verticalInput, horizontalInput);
            m_inputService.AddMovingInput(inputVector);
        }
    }
}