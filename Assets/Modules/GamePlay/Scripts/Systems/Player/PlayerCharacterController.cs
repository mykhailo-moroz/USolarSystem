using System;
using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.Player
{
    public class PlayerCharacterController : MonoBehaviour
    {
        [SerializeField]
        private ActorAnimationStateController m_animationStateController;
        
        private IInputService m_inputService;
        private CharacterController m_characterController;
        private IActor m_actor;

        private void Awake()
        {
            m_inputService = App.Services.Get<IInputService>();
            m_inputService.OnMovingInput += OnMovingInput;
            
            m_actor = GetComponent<IActor>();
            m_characterController = GetComponent<CharacterController>();
        }

        private void OnMovingInput(object sender, InputEventArgs args)
        {
            if (args.InputVector == Vector2.zero)
            {
                m_characterController.Move(Vector3.zero);
            }
            else
            {
                var projectedCameraForward = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up).normalized;
                var projectedCameraRight = Vector3.ProjectOnPlane(Camera.main.transform.right, Vector3.up).normalized;
                
                var moveVector = projectedCameraForward * args.InputVector.x + projectedCameraRight * args.InputVector.y;
                m_characterController.Move(moveVector.normalized * Time.deltaTime * 3f);   
            }
            
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;
 
            var velocity = transform.InverseTransformDirection(m_characterController.velocity).normalized;
            
            if (groundPlane.Raycast(cameraRay, out rayLength))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength); 
                //Debug.DrawLine(cameraRay.origin, pointToLook, Color.cyan);

                var lookingVector = new Vector3(pointToLook.x, transform.position.y, pointToLook.z);
                var lookingLocalVector = transform.InverseTransformPoint(lookingVector);
                var lookingAngle = Vector2.SignedAngle(new Vector2(Vector3.forward.x, Vector3.forward.z), new Vector2(lookingLocalVector.x, lookingLocalVector.z));
                Debug.Log($"Looking Angle {lookingAngle}");
                
                var aimPoint = m_actor.AimPoint;
                aimPoint.position = new Vector3(pointToLook.x, aimPoint.position.y, pointToLook.z);
                //new Vector3(transform.position.x + 0.5f * Mathf.Sin(lookingAngle/Mathf.PI), aimPoint.position.y, transform.position.z + 0.5f * Mathf.Cos(lookingAngle/Mathf.PI));
                m_actor.AimPoint = aimPoint;
                

                if (lookingAngle < -45.0f || lookingAngle > 45.0f)
                {
                    //transform.LookAt(lookingVector);
                    var lookingRotation = Quaternion.LookRotation(lookingVector - transform.position);
                    transform.rotation = Quaternion.Slerp(transform.rotation, lookingRotation, 4f * Time.deltaTime);
                    m_animationStateController.SetTurningAngle(lookingAngle);
                }
            }

            m_animationStateController.SetVelocity(Mathf.Round(velocity.x * 100.0f) * 0.01f, Mathf.Round(velocity.z * 100.0f) * 0.01f);
            
            m_characterController.Move(Vector3.down * Time.deltaTime * 9.8f);
        }
    }
}