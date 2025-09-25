using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.UI.GamePlayUI.PausePanel
{
    public class PausePanel : MonoBehaviour
    {
        [SerializeField]
        private Button m_continueButton;

        [SerializeField]
        private Button m_mainMenuButton;

        private void Awake()
        {
            m_continueButton.onClick.AddListener(() => { gameObject.SetActive(false); });
            m_mainMenuButton.onClick.AddListener(() => { SceneManager.LoadScene("MainMenuScene"); });
        }

        private void OnEnable()
        {
            Time.timeScale = 0;
        }

        private void OnDisable()
        {
            Time.timeScale = 1;
        }
    }
}