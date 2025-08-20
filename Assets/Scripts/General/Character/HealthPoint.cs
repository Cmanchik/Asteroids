using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.General.Character
{
    public class HealthPoint : MonoBehaviour
    {
        [SerializeField]
        private int health;

        public int Health { get => health; set => health = value; }

        [SerializeField]
        private UnityEvent OnDeath;

        [SerializeField]
        private UnityEvent OnTakingDamage;

        private void Awake()
        {
            OnDeath.AddListener(Death);
        }

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0) OnDeath?.Invoke();
            else OnTakingDamage?.Invoke();
        }

        private void Death()
        {
            Destroy(gameObject);
        }
    }
}