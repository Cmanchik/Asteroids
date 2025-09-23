using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.UI.GameplayUI.GameOverPanel
{
    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField]
        private Button m_mainMenuButton;

        private void Awake()
        {
            m_mainMenuButton.onClick.AddListener(OpenMainMenu);
        }

        private void OpenMainMenu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenuScene");
        }

        private void OnEnable()
        {
            Time.timeScale = 0;
        }
    }
}