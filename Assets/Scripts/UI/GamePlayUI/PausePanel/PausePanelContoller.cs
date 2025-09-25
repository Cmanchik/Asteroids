using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.UI.GamePlayUI.PausePanel
{
    public class PausePanelContoller : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_pausePanel;

        private void Awake()
        {
            InputSystem.actions.FindAction("Cancel").started += ChangeStatePanel;
        }

        private void ChangeStatePanel(InputAction.CallbackContext context)
        {
            if (m_pausePanel == null) return;


            if (m_pausePanel.activeSelf == false)
            {
                m_pausePanel.SetActive(true);
            }
            else
            {
                m_pausePanel.SetActive(false);
            }

            Debug.Log("Sosal?");
        }
    }
}