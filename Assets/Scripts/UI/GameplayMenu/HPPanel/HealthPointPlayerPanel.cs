using Assets.Scripts.General.Character;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.GameplayMenu.HPPanel
{
    public class HealthPointPlayerPanel : MonoBehaviour
    {
        [SerializeField]
        private Image[] m_healthPointsImages;

        [SerializeField]
        private HealthPoint m_healthPointPlayer;

        private void Awake()
        {
            m_healthPointPlayer.SubscribeToTakingDamage(ChangeHealthPoints);

            for (int i = 0; i < m_healthPointPlayer.MaxHealthPoints; i++)
            {
                m_healthPointsImages[i].enabled = true;
            }
        }

        private void ChangeHealthPoints()
        {
            Debug.Log("ChangeHealthPoints");

            for (int i = 0; i < m_healthPointPlayer.MaxHealthPoints; i++)
            {
                if (i < m_healthPointPlayer.CurrentHealthPoint)
                {
                    m_healthPointsImages[i].enabled = true;
                }
                else
                {
                    m_healthPointsImages[i].enabled = false;
                }
            }
        }
    }
}