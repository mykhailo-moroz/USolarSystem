using System;
using StansAssets.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

namespace SolarSystem.Modules.UI.Gameplay
{
    public class GamePlayUIController : MonoBehaviour, IGamePlayUIController, ISceneManager, ISceneDelegate
    {
        [SerializeField]
        private GameObject m_gameplayUI;
        [SerializeField]
        private Button m_pauseButton;
        
        public void OnSceneLoaded()
        {
            
        }

        public void OnSceneUnload()
        {
            
        }

        public void ActivateScene(Action onComplete)
        {
            m_gameplayUI.SetActive(true);
            onComplete.Invoke();
        }

        public void DeactivateScene(Action onComplete)
        {
            m_gameplayUI.SetActive(false);
            onComplete.Invoke();
        }
    }
}