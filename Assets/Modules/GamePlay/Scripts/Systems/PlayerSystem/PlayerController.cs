using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.PlayerSystem
{
    internal class PlayerController : MonoBehaviour
    {
        [Header("Public References")]
        [SerializeField]
        private Transform m_aimTarget;
        [SerializeField]
        private Transform m_cameraParent;
            
        [Header("Player Stats")]
        [SerializeField]
        private float m_localSpeed = 5;
        [SerializeField]
        private float m_lookSpeed = 10000;

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            LocalMove(h, v, m_localSpeed);
            RotationLook(h,v, m_lookSpeed);
            HorizontalLean(transform, h, 70, .1f);
        }
        
        private void LocalMove(float x, float y, float speed)
        {
            transform.localPosition += new Vector3(x, y, 0) * speed * Time.deltaTime; 
            ClampPosition();
        }

        private void ClampPosition()
        {
            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp01(pos.x);
            pos.y = Mathf.Clamp01(pos.y);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
        
        private void RotationLook(float h, float v, float speed)
        {
            m_aimTarget.parent.position = Vector3.zero;
            m_aimTarget.localPosition = new Vector3(h, v, 1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(m_aimTarget.position), Mathf.Deg2Rad * speed * Time.deltaTime);
        }
        
        private void HorizontalLean(Transform target, float axis, float leanLimit, float lerpTime)
        {
            Vector3 targetEulerAngels = target.localEulerAngles;
            target.localEulerAngles = new Vector3(targetEulerAngels.x, targetEulerAngels.y, Mathf.LerpAngle(targetEulerAngels.z, -axis * leanLimit, lerpTime));
        }
    }
}