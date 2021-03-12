using System;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Static;
using StansAssets.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

namespace SolarSystem.Modules.UI.MainMenu
{
    public class MainMenuController : MonoBehaviour, IMainMenuController, ISceneManager, ISceneDelegate
    {
        [SerializeField]
        private Button m_playButton;
        [SerializeField]
        private Button m_exitButton;

        [SerializeField]
        private GameObject m_mainMenu;
        
        public void OnSceneLoaded()
        {
            m_playButton.onClick.AddListener(() =>
            {
                App.State.Set(GameState.Game);
            });
            
            m_exitButton.onClick.AddListener(() =>
            {
                App.State.Set(GameState.Exit);
            });
        }

        public void OnSceneUnload()
        {
            
        }

        public void ActivateScene(Action onComplete)
        {
            m_mainMenu.SetActive(true);
            onComplete.Invoke();
        }

        public void DeactivateScene(Action onComplete)
        {
            m_mainMenu.SetActive(false);
            onComplete.Invoke();
        }
    }
}