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
        private UnityEvent Dying;

        [SerializeField]
        private UnityEvent TakingDamage;
        

        private void Awake()
        {
            m_currentHealthPoint = m_maxHealthPoints;
            Dying.AddListener(OnDying);
        }

        public void OnTakeDamage(int damage)
        {
            m_currentHealthPoint -= damage;

            if (m_currentHealthPoint <= 0) Dying?.Invoke();
            else TakingDamage?.Invoke();
        }

        public void OnTakeLethalDamage()
        {
            Dying?.Invoke();
        }

        private void OnDying()
        {
            Destroy(gameObject);
        }

        public void SubscribeToTakingDamage(UnityAction call)
        {
            TakingDamage.AddListener(call);
        }

        public void SubscribeToDying(UnityAction call)
        {
            Dying.AddListener(call);
        }
    }
}