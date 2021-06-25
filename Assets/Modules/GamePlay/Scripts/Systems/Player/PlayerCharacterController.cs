using System;
using MikeAssets.ModularServiceLocator.Runtime;
using SolarSystem.Modules.Core.Static;
using SolarSystem.Modules.GamePlay.Scripts.Static;
using SolarSystem.Modules.GamePlay.Scripts.Systems.CameraSystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.CharacterSystem;
using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.Player
{
    [Serializable]
    public enum LinesRelationship
    {
        Intersect,
        Parallel,
        Superposition,
        Equal
    }
    
    public class PlayerCharacterController : MonoBehaviour
    {
        [SerializeField]
        private ActorAnimationStateController m_animationStateController;
        
        [Header("Movement")]
        [SerializeField]
        private float m_minHeadRotAngle = -45.0f;
        [SerializeField]
        private float m_maxHeadRotAngle = -45.0f;
        [SerializeField]
        private float m_movementSpeed = 5.0f;
        [SerializeField]
        private float m_rotationSpeed = 4.0f;
        [SerializeField]
        private float m_gravityValue = 9.8f;
        [SerializeField]
        private float m_aimPointRotatingRadius = 4.0f;
        
        private ICameraService m_cameraService;
        private IInputService m_inputService;
        private CharacterController m_characterController;
        private IActor m_actor;

        private float m_actorAimYOffset;    
        
        private void Awake()
        {
            m_cameraService = App.Services.Get<ICameraService>();
            m_inputService = App.Services.Get<IInputService>();
            m_inputService.OnMovingInput += OnMovingInputChanged;
            m_inputService.OnMousePositionChanged += InputServiceOnOnMousePositionChanged;
            
            m_actor = GetComponent<IActor>();

            m_actorAimYOffset = m_actor.AimPoint.position.y;
            m_characterController = GetComponent<CharacterController>();
        }

        private void InputServiceOnOnMousePositionChanged(object sender, MousePositionInputEventArgs args)
        {
            var zeroYPlane = new Plane(Vector3.up, Vector3.zero);
            var ray = m_cameraService.MainCamera.ScreenPointToRay(args.MousePosition);
            
            if (!zeroYPlane.Raycast(ray, out var hitDist))
            {
                return;
            }
            
            var mousePos = ray.GetPoint(hitDist); 
            var mouseWorldPos = m_cameraService.MainCamera.ScreenToWorldPoint(args.MousePosition);
            var lookingPos = new Vector3(mousePos.x, 0, mousePos.z);
            var mouseWorldBase = new Vector3(mouseWorldPos.x, 0, mouseWorldPos.z);
            var mouseWordAimBase = new Vector3(mouseWorldPos.x, m_actorAimYOffset, mouseWorldPos.z); 
            var aimLineEnd = mousePos + (mouseWordAimBase - mouseWorldBase);

            MathHelper.GetLinesIntersection(mousePos, mouseWorldPos, mouseWordAimBase, aimLineEnd, out var intersection);

            var lookingLocalVector = transform.InverseTransformPoint(intersection);
            var lookingAngle = Vector2.SignedAngle(new Vector2(Vector3.forward.x, Vector3.forward.z), new Vector2(lookingLocalVector.x, lookingLocalVector.z));
            
            m_actor.AimPoint.position = intersection;

            var lookingRotation = Quaternion.LookRotation(lookingPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookingRotation, m_rotationSpeed * Time.deltaTime);
            m_animationStateController.SetTurningAngle(lookingAngle);
        }

        private void OnMovingInputChanged(object sender, MovingInputEventArgs args)
        {
            if (args.InputVector == Vector2.zero)
            {
                m_characterController.Move(Vector3.zero);
            }
            else
            {
                var projectedCameraForward = Vector3.ProjectOnPlane(m_cameraService.MainCamera.transform.forward, Vector3.up).normalized;
                var projectedCameraRight = Vector3.ProjectOnPlane(m_cameraService.MainCamera.transform.right, Vector3.up).normalized;
                
                var moveVector = projectedCameraForward * args.InputVector.x + projectedCameraRight * args.InputVector.y;
                m_characterController.Move(moveVector.normalized * Time.deltaTime * m_movementSpeed);   
            }

            var velocity = transform.InverseTransformDirection(m_characterController.velocity).normalized;
            
            m_animationStateController.SetVelocity(Mathf.Round(velocity.x * 100.0f) * 0.01f, Mathf.Round(velocity.z * 100.0f) * 0.01f);
            
            m_characterController.Move(Vector3.down * Time.deltaTime * m_gravityValue);
        }
    }
}