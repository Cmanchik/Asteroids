using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.UI.MainMenu
{
    public class MainMenuWindow : WindowAbstract
    {
        [SerializeField]
        private Button playButton;

        [SerializeField]
        private Button exitButton;

        private void Start()
        {
            playButton.onClick.AddListener(Play);
            exitButton.onClick.AddListener(Exit);
        }


        private void Play()
        {
            SceneManager.LoadScene("GamePlayScene");
        }

        private void Exit()
        {
            Application.Quit();
        }
    }
}