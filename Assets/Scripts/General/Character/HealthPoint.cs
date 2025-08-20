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

        public UnityEvent OnDeath;

        public UnityEvent OnTakingDamage;

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0) OnDeath?.Invoke();
            else OnTakingDamage?.Invoke();
        }
    }
}