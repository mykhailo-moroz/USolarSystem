using System;
using SolarSystem.Interfces;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Static;
using UnityEngine;
using UnityEngine.UI;

namespace SolarSystem.Modules.UI.MainMenu
{
    internal class MainMenuController : MonoBehaviour, IMainMenuController, ISceneManager, ISceneDelegate
    {
        [SerializeField]
        private Button m_playButton;

        [SerializeField]
        private GameObject m_mainMenu;
        
        public void OnSceneLoaded()
        {
            Debug.Log("Main menu loaded!");
            m_playButton.onClick.AddListener(() =>
            {
                App.State.Set(GameState.Game);
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