using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.General.Character
{
    public class HealthPoint : MonoBehaviour
    {
        [SerializeField]
        private int m_maxHealthPoints;
        public int MaxHealthPoints { get => m_maxHealthPoints; }


        private int m_currentHealthPoint;
        public int CurrentHealthPoint { get => m_currentHealthPoint; }

        [SerializeField]
        private UnityEvent Killing;

        [SerializeField]
        private UnityEvent TakingDamage;
        

        private void Awake()
        {
            m_currentHealthPoint = m_maxHealthPoints;
            Killing.AddListener(OnKilling);
        }

        public void OnTakeDamage(int damage)
        {
            m_currentHealthPoint -= damage;

            if (m_currentHealthPoint <= 0) Killing?.Invoke();
            else TakingDamage?.Invoke();
        }

        public void OnTakeLethalDamage()
        {
            Killing?.Invoke();
        }

        private void OnKilling()
        {
            Destroy(gameObject);
        }

        public void SubscribeToTakingDamage(UnityAction call)
        {
            TakingDamage.AddListener(call);
        }

        public void SubscribeToKilling(UnityAction call)
        {
            Killing.AddListener(call);
        }
    }
}