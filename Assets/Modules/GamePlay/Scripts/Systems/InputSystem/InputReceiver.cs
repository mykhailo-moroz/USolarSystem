using System;
using MikeAssets.ModularServiceLocator.Runtime;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class InputReceiver : MonoBehaviour
    {
        private IInputService m_inputService;
        private bool m_isInputLocked = true;

        private void Start()
        {
            try
            {
                m_inputService = App.Services.Get<IInputService>();
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }

        public void LockInput(bool lockInput)
        {
            m_isInputLocked = lockInput;
        }
        
        private void Update()
        {
            if (m_isInputLocked)
            {
                return;
            }
            
            var horizontalInput = Input.GetAxis("Horizontal");
            var verticalInput = Input.GetAxis("Vertical");

            var inputVector = new Vector2(verticalInput, horizontalInput);
            m_inputService.AddMovingInput(inputVector);
            m_inputService.AddLookingInput(Input.mousePosition);
        }
    }
}